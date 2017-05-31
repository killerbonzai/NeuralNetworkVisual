using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralInterface
{
    class NetworkData
    {
        public string Name { get; set; }
        // input data
        public double Input0 { get; set; }
        public double Input1 { get; set; }

        // hidden data
        public List<Data> HiddenNeurons { get; set; }

        // output data
        public Data OutputNeuron { get; set; }
    }

    class Data
    {
        public double Output { get; set; }
        public double Bias { get; set; }
        public double Sum { get; set; }
        public double Weight0 { get; set; }
        public double Weight1 { get; set; }
        public double Weight2 { get; set; }
    }
}
