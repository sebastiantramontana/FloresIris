using FloresForm.ParametrosAlgoritmosEntrenamiento;
using IrisForm.Datasets;
using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Delegates;
using NeuralNetworkNET.APIs.Enums;
using NeuralNetworkNET.APIs.Interfaces;
using NeuralNetworkNET.APIs.Structs;
using NeuralNetworkNET.Networks.Cost;
using NeuralNetworkNET.SupervisedLearning.Algorithms;
using NeuralNetworkNET.SupervisedLearning.Progress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisForm
{
    public partial class Form1 : Form
    {
        private INeuralNetwork _neuralNetwork;
        private CancellationTokenSource _cancellationTokenSource;
        private bool _entrenando = false;
        private string _monitorLog = string.Empty;

        public Form1()
        {
            InitializeComponent();

            LlenarComboFuncionesActivacionOculta();
            LlenarCombosInicializacionPesos();
            LlenarCombosInicializacionBias();
            LlenarComboFuncionesActivacionSalida();
            LlenarComboCosto();
            LlenarComboAlgoritmoEntrenmiento();
        }

        private void LlenarComboAlgoritmoEntrenmiento()
        {
            var algos = EnumInfo<TrainingAlgorithmType>.GetInfos();
            LlenarCombo(cboAlgoritmoEntrenamiento, algos, TrainingAlgorithmType.Momentum);

            gridParametrosAlgoritmoEntrenamiento.SelectedObject = new Momentum
            {
                LearningRate = 0.003f,
                Regularization = 0.5f,
                Coefficient = 0.1f
            };
        }

        private void LlenarComboCosto()
        {
            var costos = EnumInfo<CostFunctionType>.GetInfos();
            var sinLogLikelyhood = costos.Where(c => c.Valor != CostFunctionType.LogLikelyhood);

            LlenarCombo(cboFuncionCosto, sinLogLikelyhood, CostFunctionType.CrossEntropy);
        }

        private void LlenarComboFuncionesActivacionSalida()
        {
            var funciones = DevolverFuncionesActivacion();
            LlenarCombo(cboFuncionActivacionSalida, funciones, ActivationType.Sigmoid);
        }

        private void LlenarCombosInicializacionBias()
        {
            var biasesIni = EnumInfo<BiasInitializationMode>.GetInfos();

            LlenarCombo(cboBiasOculta, biasesIni, BiasInitializationMode.Gaussian);
            LlenarCombo(cboBiasSalida, biasesIni, BiasInitializationMode.Gaussian);
        }

        private void LlenarCombosInicializacionPesos()
        {
            var pesosIni = EnumInfo<WeightsInitializationMode>.GetInfos();

            LlenarCombo(cboPesosOculta, pesosIni, WeightsInitializationMode.LeCunUniform);
            LlenarCombo(cboPesosSalida, pesosIni, WeightsInitializationMode.LeCunUniform);
        }

        private void LlenarComboFuncionesActivacionOculta()
        {
            var funciones = DevolverFuncionesActivacion();
            var sinSoftmax = funciones.Where(f => f.Valor != ActivationType.Softmax);

            LlenarCombo(cboFuncionActivacionOculta, sinSoftmax, ActivationType.ReLU);
        }

        private void LlenarCombo<TEnum>(ComboBox comboBox, IEnumerable<EnumInfo<TEnum>> valores, EnumInfo<TEnum> seleccionado) where TEnum : struct, Enum
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(valores.ToArray());
            comboBox.SelectedItem = seleccionado;
        }

        private void LlenarCombo<TEnum>(ComboBox comboBox, IEnumerable<EnumInfo<TEnum>> valores, TEnum seleccionado) where TEnum : struct, Enum
        {
            LlenarCombo(comboBox, valores, valores.Single(v => v.Equals(seleccionado)));
        }

        private void CrearNeuralNetwork()
        {
            int neuronasOcultas = (int)spinNeuronasOculta.Value;
            var activacionOculta = cboFuncionActivacionOculta.SelectedItem as EnumInfo<ActivationType>;
            var pesosOculta = cboPesosOculta.SelectedItem as EnumInfo<WeightsInitializationMode>;
            var biasOculta = cboBiasOculta.SelectedItem as EnumInfo<BiasInitializationMode>;

            var activacionSalida = cboFuncionActivacionSalida.SelectedItem as EnumInfo<ActivationType>;
            var funcionCosto = cboFuncionCosto.SelectedItem as EnumInfo<CostFunctionType>;
            var pesosSalida = cboPesosSalida.SelectedItem as EnumInfo<WeightsInitializationMode>;
            var biasSalida = cboBiasSalida.SelectedItem as EnumInfo<BiasInitializationMode>;

            LayerFactory layerSalida;

            if (activacionSalida.Valor == ActivationType.Softmax)
            {
                layerSalida = NetworkLayers.Softmax(3, pesosOculta.Valor, biasOculta.Valor);
            }
            else
            {
                layerSalida = NetworkLayers.FullyConnected(3, activacionSalida.Valor, funcionCosto.Valor, pesosSalida.Valor, biasSalida.Valor);
            }

            _neuralNetwork = NetworkManager.NewSequential(TensorInfo.Linear(4),
                NetworkLayers.FullyConnected(neuronasOcultas, activacionOculta.Valor, pesosOculta.Valor, biasOculta.Valor),
                layerSalida);
        }

        private async void btnEntrenar_Click(object sender, EventArgs e)
        {
            CrearNeuralNetwork();

            _cancellationTokenSource = new CancellationTokenSource();

            btnCancelar.Focus();
            txtMonitor.Text = string.Empty;
            _monitorLog = string.Empty;

            var dataset = new Dataset();
            var datasets = dataset.Cargar();

            _entrenando = true;
            HabilitarBotones(false);

            var algoritmo = gridParametrosAlgoritmoEntrenamiento.SelectedObject as IAlgoritmoParametros;

            await Task.Run(() =>
            {
                NetworkManager.TrainNetwork(
                _neuralNetwork,
                datasets.Training, 
                algoritmo.GetTrainingAlgorithm(),
                (int)spinIteraciones.Value,
                (float) spinDropout.Value,
                null,
                MonitorearIteraciones,
                null,
                datasets.Test,
                _cancellationTokenSource.Token);

                _entrenando = false;

                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;

                MostrarLog();
                HabilitarBotones(true);
                EjecutarActionUI(() => { btnPredecir.Focus(); });
            });
        }

        private void HabilitarBotones(bool listoParaPredecir)
        {
            Action action = () =>
            {
                btnEntrenar.Enabled = !(btnCancelar.Enabled = _entrenando);
                btnPredecir.Enabled = listoParaPredecir;
            };

            EjecutarActionUI(action);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_entrenando == true)
                _cancellationTokenSource.Cancel();
        }

        private void btnPredecir_Click(object sender, EventArgs e)
        {
            var sepalLength = ParsearControlInput(txtSepalLength);
            if (float.IsNaN(sepalLength))
                return;

            var sepalWidth = ParsearControlInput(txtSepalWidth);
            if (float.IsNaN(sepalWidth))
                return;

            var petalLength = ParsearControlInput(txtPetalLength);
            if (float.IsNaN(petalLength))
                return;

            var petalWidth = ParsearControlInput(txtPetalWidth);
            if (float.IsNaN(petalWidth))
                return;

            var valoresSalida = _neuralNetwork.Forward(new[] { sepalLength, sepalWidth, petalLength, petalWidth });
            //var resultado = new Prediccion(valoresSalida);

            txtSetosa.Text = valoresSalida[0].ToString();
            txtVersicolor.Text = valoresSalida[1].ToString();
            txtVirginica.Text = valoresSalida[2].ToString();
        }

        private float ParsearControlInput(Control control)
        {
            if (!float.TryParse(control.Text, out var valor))
            {
                MessageBox.Show("El valor de entrada es inválido");
                control.Focus();
                return float.NaN;
            }

            return valor;
        }

        private void MonitorearIteraciones(TrainingProgressEventArgs trainingProgress)
        {
            if (_entrenando == false) //puede quedar el thread andando pese a la finalización o cancelacion
                return;

            EjecutarActionUI(() =>
            {
                var msj = $"Iteración: {trainingProgress.Iteration}, Exactitud: {trainingProgress.Result.Accuracy}%, Costo: {trainingProgress.Result.Cost}" + Environment.NewLine;
                _monitorLog += msj;
                txtMonitor.Text = msj;
            });
        }

        private void MostrarLog()
        {
            Action action = () => { txtMonitor.Text += _monitorLog; };
            EjecutarActionUI(action);
        }

        private void EjecutarActionUI(Action action)
        {
            if (this.IsHandleCreated)
            {
                if (this.InvokeRequired)
                    this.Invoke(action);
                else
                    action();
            }
        }

        private IEnumerable<EnumInfo<ActivationType>> DevolverFuncionesActivacion()
        {
            return EnumInfo<ActivationType>.GetInfos();
        }

        private void cboFuncionActivacionSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated)
                return;

            var funcionActivacion = cboFuncionActivacionSalida.SelectedItem as EnumInfo<ActivationType>;
            var funcCostos = funcionActivacion.GetCostFunctionsPermitidas();

            LlenarCombo(cboFuncionCosto, funcCostos, funcCostos.First());
        }

        private void cboAlgoritmoEntrenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated)
                return;

            var algoritmos = cboAlgoritmoEntrenamiento.SelectedItem as EnumInfo<TrainingAlgorithmType>;
            gridParametrosAlgoritmoEntrenamiento.SelectedObject = algoritmos.GetParametrizacion();
        }
    }
}
