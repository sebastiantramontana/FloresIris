using FloresForm.ParametrosAlgoritmosEntrenamiento;
using NeuralNetworkModel.Model;
using NeuralNetworkNET.APIs.Enums;
using NeuralNetworkNET.Networks.Cost;
using NeuralNetworkNET.SupervisedLearning.Algorithms;
using System;
using System.Collections.Generic;

namespace IrisForm
{
    public static class Extensiones
    {
        public static ActivationFunction Map(this ActivationType activationType)
        {
            switch (activationType)
            {
                case ActivationType.Sigmoid:
                    return ActivationFunction.Sigmoid;
                case ActivationType.Tanh:
                case ActivationType.LeCunTanh:
                    return ActivationFunction.Tanh;
                case ActivationType.ReLU:
                case ActivationType.ELU:
                case ActivationType.AbsoluteReLU:
                case ActivationType.Softplus:
                    return ActivationFunction.Relu;
                case ActivationType.LeakyReLU:
                    return ActivationFunction.LeakyRelu;
                case ActivationType.Softmax:
                    return ActivationFunction.Softmax;
                case ActivationType.Identity:
                    return ActivationFunction.Linear;
                default:
                    break;
            }

            throw new NotImplementedException($"Función de activación no implementada: {activationType}");
        }

        public static IEnumerable<EnumInfo<CostFunctionType>> GetCostFunctionsPermitidas(this EnumInfo<ActivationType> activationFunction)
        {
            switch (activationFunction.Valor)
            {
                case ActivationType.Identity:
                case ActivationType.ReLU:
                case ActivationType.LeakyReLU:
                case ActivationType.AbsoluteReLU:
                case ActivationType.ELU:
                case ActivationType.LeCunTanh:
                case ActivationType.Softplus:
                case ActivationType.Tanh:
                    return new[] { EnumInfo<CostFunctionType>.From(CostFunctionType.Quadratic) };
                case ActivationType.Sigmoid:
                    return new[]
                    {
                        EnumInfo<CostFunctionType>.From(CostFunctionType.Quadratic),
                        EnumInfo<CostFunctionType>.From(CostFunctionType.CrossEntropy)
                    };
                case ActivationType.Softmax:
                    return new[] { EnumInfo<CostFunctionType>.From(CostFunctionType.LogLikelyhood) };
            }

            throw new NotImplementedException($"Función de costo no implementada para la función de activación: {activationFunction}");
        }

        public static IAlgoritmoParametros GetParametrizacion(this EnumInfo<TrainingAlgorithmType> enumInfo)
        {
            switch (enumInfo.Valor)
            {
                case TrainingAlgorithmType.StochasticGradientDescent:
                    return new StochasticGradientDescent();
                case TrainingAlgorithmType.Momentum:
                    return new Momentum();
                case TrainingAlgorithmType.AdaGrad:
                    return new AdaGrad();
                case TrainingAlgorithmType.AdaDelta:
                    return new AdaDelta();
                case TrainingAlgorithmType.Adam:
                    return new Adam();
                case TrainingAlgorithmType.AdaMax:
                    return new AdaMax();
                case TrainingAlgorithmType.RMSProp:
                    return new RMSProp();
                default:
                    break;
            }

            throw new InvalidOperationException($"Algoritmo de entrenamiento no implementado: {enumInfo.Valor}");
        }
    }
}
