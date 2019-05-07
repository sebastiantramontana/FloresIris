using IrisForm.Datasets;
using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Enums;
using NeuralNetworkNET.APIs.Interfaces;
using NeuralNetworkNET.APIs.Structs;
using NeuralNetworkNET.Networks.Cost;
using NeuralNetworkNET.SupervisedLearning.Progress;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisForm
{
    public partial class Form1 : Form
    {
        private INeuralNetwork _neuralNetwork;
        private const int ITERACIONES = 5000;

        private CancellationTokenSource _cancellationTokenSource;
        private bool _entrenando = false;
        private string _monitorLog = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _neuralNetwork = NetworkManager.NewSequential(TensorInfo.Linear(4),
                NetworkLayers.FullyConnected(8, ActivationType.ReLU, WeightsInitializationMode.LeCunUniform, BiasInitializationMode.Zero),
                NetworkLayers.FullyConnected(3, ActivationType.Sigmoid, CostFunctionType.CrossEntropy, WeightsInitializationMode.LeCunUniform, BiasInitializationMode.Zero));
        }

        private async void btnEntrenar_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            btnCancelar.Focus();
            txtMonitor.Text = string.Empty;
            _monitorLog = string.Empty;

            var dataset = new Dataset();
            var datasets = dataset.Cargar();

            _entrenando = true;
            HabilitarBotones(false);

            await Task.Run(() =>
            {
                NetworkManager.TrainNetwork(
                _neuralNetwork,
                datasets.Training,
                TrainingAlgorithms.Momentum(0.003f, 0.5f, 0.1f),
                ITERACIONES,
                0.999f,
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

            var valoresSoftmax = _neuralNetwork.Forward(new[] { sepalLength, sepalWidth, petalLength, petalWidth });
            var resultado = new Prediccion(valoresSoftmax);

            txtResultado.Text = $"{resultado.Tipo} ({resultado.Probabilidad})";
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
    }
}
