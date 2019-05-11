using NeuralNetworkNET.APIs.Interfaces;

namespace FloresForm.ParametrosAlgoritmosEntrenamiento
{
    public interface IAlgoritmoParametros
    {
        ITrainingAlgorithmInfo GetTrainingAlgorithm();
    }
}