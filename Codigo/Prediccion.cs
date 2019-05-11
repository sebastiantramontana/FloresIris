using IrisForm.Dominio;

namespace IrisForm
{
    public class Prediccion
    {
        public Prediccion(float[] valores)
        {
            float maxProbabilidad = 0.0f;
            int maxIndice = -1;

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > maxProbabilidad)
                {
                    maxProbabilidad = valores[i];
                    maxIndice = i;
                }
            }

            var tipo = TipoIris.Desconocida;

            switch (maxIndice)
            {
                case 0:
                    tipo = TipoIris.Setosa;
                    break;
                case 1:
                    tipo = TipoIris.Versicolor;
                    break;
                case 2:
                    tipo = TipoIris.Virginica;
                    break;
            }

            this.Tipo = tipo;
            this.Probabilidad = maxProbabilidad;
            this.Valores = valores;
        }

        public TipoIris Tipo { get; }
        public float Probabilidad { get; }
        public float[] Valores { get; }
    }
}
