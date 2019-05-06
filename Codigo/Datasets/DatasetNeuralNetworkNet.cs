using NeuralNetworkNET.APIs.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisForm
{
    public class DatasetNeuralNetworkNet
    {
        public ITrainingDataset Training { get; }
        public ITestDataset Test { get; }

        public DatasetNeuralNetworkNet(ITrainingDataset training, ITestDataset test)
        {
            this.Training = training;
            this.Test = test;
        }
    }
}
