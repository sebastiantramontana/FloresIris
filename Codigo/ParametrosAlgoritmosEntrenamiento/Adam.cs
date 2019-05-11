using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces;

namespace FloresForm.ParametrosAlgoritmosEntrenamiento
{
    public class Adam : IAlgoritmoParametros
    {
        public float Eta { get; set; } = 0.001f;
        public float Beta1 { get; set; } = 0.9f;
        public float Beta2 { get; set; } = 0.999f;
        public float Epsilon { get; set; } = 1E-08f;

        public ITrainingAlgorithmInfo GetTrainingAlgorithm()
        {
            return TrainingAlgorithms.Adam(this.Eta, this.Beta1, this.Beta2, this.Epsilon);
        }
    }
}
