using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;

namespace FloresForm.ParametrosAlgoritmosEntrenamiento
{
    public class RMSProp : IAlgoritmoParametros
    {
        public float Eta { get; set; } = 0.01f;
        public float Rho { get; set; } = 0.9f;
        public float Lambda { get; set; } = 0f;
        public float Epsilon { get; set; } = 1E-08f;

        public ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.RMSProp(this.Eta, this.Rho, this.Lambda, this.Epsilon);
        }
    }
}
