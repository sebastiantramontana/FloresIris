﻿using System;

namespace IrisForm.Dominio
{
    public static class TipoIrisExtensiones
    {
        public static float[] ToSoftmaxTraining(this TipoIris tipoIris)
        {
            float[] salida;

            switch (tipoIris)
            {
                case TipoIris.Setosa:
                    salida = new[] { 1f, 0f, 0f };
                    break;
                case TipoIris.Versicolor:
                    salida = new[] { 0f, 1f, 0f };
                    break;
                case TipoIris.Virginica:
                    salida = new[] { 0f, 0f, 1f };
                    break;
                case TipoIris.Desconocida:
                    throw new InvalidOperationException("No se puede convertir una salida softmax de un tipo de iris desconocido");
                default:
                    throw new NotImplementedException($"Tipo de iris no implementado: {tipoIris}");
            }

            return salida;
        }
    }
}
