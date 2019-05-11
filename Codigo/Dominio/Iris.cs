namespace IrisForm.Dominio
{
    public class Iris
    {
        public float SepalLength { get; set; }
        public float SepalWidth { get; set; }
        public float PetalLength { get; set; }
        public float PetalWidth { get; set; }
        public TipoIris Tipo { get; set; }

        public static TipoIris ParsearTipo(string label)
        {
            var tipo = TipoIris.Desconocida;

            switch (label.Trim())
            {
                case "Iris-setosa":
                    tipo = TipoIris.Setosa;
                    break;
                case "Iris-versicolor":
                    tipo = TipoIris.Versicolor;
                    break;
                case "Iris-virginica":
                    tipo = TipoIris.Virginica;
                    break;
            }

            return tipo;
        }

        public override string ToString()
        {
            return $"{this.Tipo}: {this.SepalLength},{this.SepalWidth},{this.PetalLength},{this.PetalWidth}";
        }
    }
}
