using IrisForm.Dominio;
using IrisForm.Properties;
using NeuralNetworkNET.APIs;
using NeuralNetworkNET.APIs.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IrisForm.Datasets
{
    public class Dataset
    {
        public DatasetNeuralNetworkNet Cargar()
        {
            var irises = LeerArchivoDataset();

            var setosas = SepararDatasetSegunTipo(irises, TipoIris.Setosa);
            var versicolores = SepararDatasetSegunTipo(irises, TipoIris.Versicolor);
            var virginicas = SepararDatasetSegunTipo(irises, TipoIris.Virginica);

            var training = UnirTiposIrisEnDatasetEspecifo(new[] { setosas, versicolores, virginicas }, (irisesTipo) => irisesTipo.Training);
            var test = UnirTiposIrisEnDatasetEspecifo(new[] { setosas, versicolores, virginicas }, (irisesTipo) => irisesTipo.Test);

            var dataTraining = CrearDataset(training, (values) => DatasetLoader.Training(values, 50));
            var dataTest = CrearDataset(training, (values) => DatasetLoader.Test(values, null));

            return new DatasetNeuralNetworkNet(dataTraining, dataTest);
        }

        private TDataset CrearDataset<TDataset>(IEnumerable<Iris> irises, Func<IEnumerable<(float[], float[])>, TDataset> datasetFunc)
            where TDataset : IDataset
        {
            var data = new List<(float[], float[])>(irises.Count());

            foreach (var train in irises)
            {
                var trainInputs = new[] { train.SepalLength, train.SepalWidth, train.PetalLength, train.PetalWidth };
                var trainOutputs = train.Tipo.ToSoftmaxTraining();
                data.Add((trainInputs, trainOutputs));
            }

            return datasetFunc(data);
        }

        private IEnumerable<Iris> UnirTiposIrisEnDatasetEspecifo(IEnumerable<(IEnumerable<Iris> Training, IEnumerable<Iris> Test)> irisesMismoTipo, Func<(IEnumerable<Iris> Training, IEnumerable<Iris> Test), IEnumerable<Iris>> datasetEspecificoFunc)
        {
            var datasetEspecifico = new List<Iris>();

            foreach (var irises in irisesMismoTipo)
            {
                datasetEspecifico.AddRange(datasetEspecificoFunc(irises));
            }

            return datasetEspecifico;
        }

        private (IEnumerable<Iris> Training, IEnumerable<Iris> Test) SepararDatasetSegunTipo(IEnumerable<Iris> irises, TipoIris tipo)
        {
            var irisesTipo = irises.Where((iris) => iris.Tipo == tipo);

            var test = irisesTipo.Take(irisesTipo.Count() / 4);
            var training = irisesTipo.Where((iris) => !test.Contains(iris));

            return (training, test);
        }

        private IEnumerable<Iris> LeerArchivoDataset()
        {
            var texto = Encoding.ASCII.GetString(Resources.IrisDataset);
            var lineas = texto.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var irises = new List<Iris>(lineas.Length);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                var valores = linea.Split(',');

                var iris = new Iris
                {
                    SepalLength = float.Parse(valores[0]),
                    SepalWidth = float.Parse(valores[1]),
                    PetalLength = float.Parse(valores[2]),
                    PetalWidth = float.Parse(valores[3]),
                    Tipo = Iris.ParsearTipo(valores[4])
                };

                irises.Add(iris);
            }

            return irises;
        }
    }
}
