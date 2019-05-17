using FloresForm.ParametrosAlgoritmosEntrenamiento;
using IrisForm.Datasets;
using NeuralNetworkModel.Model.Layers;
using NeuralNetworkModel.Model.Nodes;
using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Delegates;
using NeuralNetworkNET.APIs.Enums;
using NeuralNetworkNET.APIs.Interfaces;
using NeuralNetworkNET.APIs.Results;
using NeuralNetworkNET.APIs.Structs;
using NeuralNetworkNET.Networks.Cost;
using NeuralNetworkNET.SupervisedLearning.Algorithms;
using NeuralNetworkNET.SupervisedLearning.Progress;
using NeuralNetworkVisualizer.Preferences.Brushes;
using NeuralNetworkVisualizer.Preferences.Formatting;
using NeuralNetworkVisualizer.Preferences.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarVisualizer();
        }

        private void InicializarVisualizer()
        {
            neuralNetworkVisualizerControl1.InputLayer = InicializarModeloVisualizer();

            neuralNetworkVisualizerControl1.Preferences.Perceptrons.OutputValueFormatter = new ByValueSignFormatter<TextPreference>(
               () => new TextPreference { Brush = new SolidBrushPreference(Color.Red) },
               () => new TextPreference { Brush = new SolidBrushPreference(Color.Gray) },
               () => new TextPreference { Brush = new SolidBrushPreference(Color.Black) },
               () => new TextPreference { Brush = new SolidBrushPreference(Color.Black) }
           );

            neuralNetworkVisualizerControl1.Preferences.Edges.ValueFormatter = new ByValueSignFormatter<TextPreference>(
                () => new TextPreference { Brush = new SolidBrushPreference(Color.Red) },
                () => new TextPreference { Brush = new SolidBrushPreference(Color.Gray) },
                () => new TextPreference { Brush = new SolidBrushPreference(Color.Black) },
                () => new TextPreference { Brush = new SolidBrushPreference(Color.Black) });

            neuralNetworkVisualizerControl1.Preferences.Edges.Connector = new ByValueSignFormatter<Pen>(
                () => new Pen(Color.Red),
                () => new Pen(Color.LightSteelBlue),
                () => new Pen(Color.Black),
                () => new Pen(Color.Gray));

            neuralNetworkVisualizerControl1.Preferences.Layers.Title = null;
            neuralNetworkVisualizerControl1.Preferences.Quality = RenderQuality.High;
            neuralNetworkVisualizerControl1.Preferences.AsyncRedrawOnResize = false;
            neuralNetworkVisualizerControl1.Selectable = false;

            neuralNetworkVisualizerControl1.RedrawAsync();
        }

        private InputLayer InicializarModeloVisualizer()
        {
            var inputLayer = new InputLayer("Input");

            var sepalLengthInput = new Input("Sepal Length");
            var SepalWidthInput = new Input("Sepal Width");
            var PetalLengthInput = new Input("PetalLength");
            var PetalWidthInput = new Input("Petal Width");

            inputLayer.AddNode(sepalLengthInput);
            inputLayer.AddNode(SepalWidthInput);
            inputLayer.AddNode(PetalLengthInput);
            inputLayer.AddNode(PetalWidthInput);
            inputLayer.Bias = new Bias("Bias Input") { OutputValue = 1.0 };

            var capaOculta = new PerceptronLayer("Oculta");

            var cantNeuronasOcultas = (int)spinNeuronasOculta.Value;
            var funcionActivacion = (cboFuncionActivacionOculta.SelectedItem as EnumInfo<ActivationType>).Valor.Map();

            for (int i = 0; i < cantNeuronasOcultas; i++)
            {
                var neurona = new Perceptron("oculta" + i)
                {
                    ActivationFunction = funcionActivacion
                };

                capaOculta.AddNode(neurona);
            }

            capaOculta.Bias = new Bias("Bias Oculta") { OutputValue = 1.0 };

            inputLayer.Connect(capaOculta);

            funcionActivacion = (cboFuncionActivacionSalida.SelectedItem as EnumInfo<ActivationType>).Valor.Map();

            var setosaOutput = new Perceptron("Setosa") { ActivationFunction = funcionActivacion };
            var versicolorOutput = new Perceptron("Versicolor") { ActivationFunction = funcionActivacion };
            var virginicaOutput = new Perceptron("Virginica") { ActivationFunction = funcionActivacion };

            var capaSalida = new PerceptronLayer("Salida");

            capaSalida.AddNode(setosaOutput);
            capaSalida.AddNode(versicolorOutput);
            capaSalida.AddNode(virginicaOutput);

            capaOculta.Connect(capaSalida);

            return inputLayer;
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
                var resultados = NetworkManager.TrainNetwork(
                _neuralNetwork,
                datasets.Training,
                algoritmo.GetTrainingAlgorithm(),
                (int)spinIteraciones.Value,
                (float)spinDropout.Value,
                null,
                MonitorearIteraciones,
                null,
                datasets.Test,
                _cancellationTokenSource.Token);

                _entrenando = false;

                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;

                EjecutarActionUI(() => MostrarLog(resultados.CompletedEpochs, resultados.TestReports.Last()));
                EjecutarActionUI(() => ActualizarNeuralNetworkVisualizerFull());
                EjecutarActionUI(() => { HabilitarBotones(true); });
                EjecutarActionUI(() => { btnPredecir.Focus(); });
            });
        }

        private void HabilitarBotones(bool listoParaPredecir)
        {
            btnEntrenar.Enabled = !(btnCancelar.Enabled = _entrenando);
            btnPredecir.Enabled = listoParaPredecir;
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

            ActualizarNeuralNetworkVisualizerNodos();
            neuralNetworkVisualizerControl1.Redraw();
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

                ActualizarNeuralNetworkVisualizerFull();
            });
        }

        private void MostrarLog(int totalIteraciones, DatasetEvaluationResult result)
        {
            _monitorLog = $"Total iteraciones: {totalIteraciones}, Exactitud: {result.Accuracy}%, Costo: {result.Cost}"
                + Environment.NewLine
                + _monitorLog;

            txtMonitor.Text = _monitorLog;
        }

        private void EjecutarActionUI(Action action)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                if (this.InvokeRequired)
                    this.Invoke(action);
                else
                    action();
            }
        }

        private void ActualizarNeuralNetworkVisualizerFull()
        {
            ActualizarNeuralNetworkVisualizerNodos();
            ActualizarNeuralNetworkVisualizerPesos();

            neuralNetworkVisualizerControl1.RedrawAsync();
        }

        private void ActualizarNeuralNetworkVisualizerPesos()
        {
            SetearPesosVisualizer(0, neuralNetworkVisualizerControl1.InputLayer.Next);
            SetearPesosVisualizer(1, neuralNetworkVisualizerControl1.InputLayer.Next.Next);
        }

        private void ActualizarNeuralNetworkVisualizerNodos()
        {
            SetearOutputsVisualizer(neuralNetworkVisualizerControl1.InputLayer, _neuralNetwork.Layers[0].InputValues);

            SetearSumsVisualizer(neuralNetworkVisualizerControl1.InputLayer.Next, _neuralNetwork.Layers[0].SumValues);
            SetearOutputsVisualizer(neuralNetworkVisualizerControl1.InputLayer.Next, _neuralNetwork.Layers[0].OutputValues);

            SetearSumsVisualizer(neuralNetworkVisualizerControl1.InputLayer.Next.Next, _neuralNetwork.Layers[1].SumValues);
            SetearOutputsVisualizer(neuralNetworkVisualizerControl1.InputLayer.Next.Next, _neuralNetwork.Layers[1].OutputValues);
        }

        private void SetearPesosVisualizer(int layerIndex, PerceptronLayer layerVisualizer)
        {
            IWeightedLayer layer = _neuralNetwork.Layers[layerIndex] as IWeightedLayer;
            var pesosNeuronas = layer.Weights;
            var pesosBias = layer.Biases;

            var nodos = layerVisualizer.Nodes;
            int i = 0;

            foreach (var nodo in nodos)
            {
                var edgeBias = nodo.Edges.Single(e => e.Source is Bias);
                var edges = nodo.Edges.Where(e => e != edgeBias).ToArray();

                for (int j = 0; j < edges.Length; ++j)
                {
                    edges[j].Weight = pesosNeuronas[j + i];
                }

                edgeBias.Weight = pesosBias[i];

                ++i;
            }
        }

        private void SetearOutputsVisualizer<TNode>(LayerBase<TNode> layer, float[] valores) where TNode : NodeBase
        {
            var nodes = layer.Nodes.ToArray();

            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i].OutputValue = valores[i];
            }
        }

        private void SetearSumsVisualizer(PerceptronLayer layer, float[] valores)
        {
            var nodes = layer.Nodes.ToArray();

            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i].SumValue = valores[i];
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

            ModificarModeloNeuralNetworkVisualizer();

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

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            neuralNetworkVisualizerControl1.Zoom += 0.1f;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            neuralNetworkVisualizerControl1.Zoom -= 0.1f;
        }

        private void spinNeuronasOculta_ValueChanged(object sender, EventArgs e)
        {
            ModificarModeloNeuralNetworkVisualizer();
        }

        private void cboFuncionActivacionOculta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModificarModeloNeuralNetworkVisualizer();
        }

        private void ModificarModeloNeuralNetworkVisualizer()
        {
            if (!this.IsHandleCreated)
                return;

            neuralNetworkVisualizerControl1.InputLayer = InicializarModeloVisualizer();
        }
    }
}
