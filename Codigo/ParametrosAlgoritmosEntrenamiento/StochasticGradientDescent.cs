using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;
using System.ComponentModel;

namespace FloresForm.ParametrosAlgoritmosEntrenamiento
{
    public class StochasticGradientDescent : IAlgoritmoParametros
    {
        [Description("También conocido como Eta")]
        public float LearningRate { get; set; } = 0.01f;

        [Description("También conocido como Lambda")]
        public float Regularization { get; set; } = 0f;

        public virtual ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.StochasticGradientDescent(this.LearningRate, this.Regularization);
        }
    }
}
