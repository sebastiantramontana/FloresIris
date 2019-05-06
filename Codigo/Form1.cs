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
using IrisForm.Datasets;

namespace IrisForm
{
    public partial class Form1 : Form
    {
        private INeuralNetwork _neuralNetwork;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _neuralNetwork = NetworkManager.NewSequential(TensorInfo.Linear(4),
                NetworkLayers.FullyConnected(8, ActivationType.ReLU, WeightsInitializationMode.LeCunUniform, BiasInitializationMode.Zero),
                NetworkLayers.FullyConnected(3, ActivationType.Sigmoid, CostFunctionType.CrossEntropy, WeightsInitializationMode.LeCunUniform, BiasInitializationMode.Zero));
                //NetworkLayers.Softmax(3, WeightsInitializationMode.LeCunUniform, BiasInitializationMode.Gaussian));

            /*
            _neuralNetwork = NetworkManager.NewGraph(TensorInfo.Linear(4), builder =>
                   {
                       var relu = builder.Layer(NetworkLayers.FullyConnected(4, ActivationType.ReLU));
                       var sigmoid = builder.Layer(NetworkLayers.FullyConnected(4, ActivationType.Sigmoid));

                       var sum = relu + sigmoid;
                       sum.Layer(NetworkLayers.FullyConnected(3, ActivationType.Sigmoid, CostFunctionType.CrossEntropy));
                   });
                  */
        }

        private CancellationTokenSource _cancellationTokenSource;
        private async void button1_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            txtMonitor.Text = string.Empty;

            var dataset = new Dataset();
            var datasets = dataset.Cargar();

            await Task.Run(() =>
            {
                NetworkManager.TrainNetwork(
                _neuralNetwork,
                datasets.Training,
                TrainingAlgorithms.Momentum(0.003f, 0.5f, 0.1f), //StochasticGradientDescent(0.003f, 0.5f),
                5000,
                0.999f,
                null,
                MonitorearIteraciones,
                null,
                datasets.Test,
                _cancellationTokenSource.Token);

                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;

                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() => { txtMonitor.Text += _monitorLog; }));
                }
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel(false);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private string _monitorLog = string.Empty;
        private async void MonitorearIteraciones(TrainingProgressEventArgs trainingProgress)
        {
            await Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    var msj = $"Iteración: {trainingProgress.Iteration}, Exactitud: {trainingProgress.Result.Accuracy}%, Costo: {trainingProgress.Result.Cost}" + Environment.NewLine;
                    _monitorLog += msj;
                    txtMonitor.Text = msj;
                    txtMonitor.Refresh();
                }));
            });
        }
    }
}
