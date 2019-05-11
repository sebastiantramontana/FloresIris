using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;

namespace FloresForm.ParametrosAlgoritmosEntrenamiento
{
    public class AdaMax : IAlgoritmoParametros
    {
        public float Eta { get; set; } = 0.002f;
        public float Beta1 { get; set; } = 0.9f;
        public float Beta2 { get; set; } = 0.999f;

        public ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.AdaMax(this.Eta, this.Beta1, this.Beta2);
        }
    }
}
