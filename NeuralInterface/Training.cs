using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralInterface
{
    public class Training
    {
        private NeuralNet net;
        private double error { get; set; }
        private double deltaOutputSum { get; set; }
        private double[] deltaHiddenSum { get; set; }

        public void Train(double targetValue, NeuralNet net)
        {
            this.net = net;

            // error
            error = targetValue - net.OutputLayer.neurons[0].Output;

            // dealtaoutput
            deltaOutputSum = SigmoidDerivative(net.OutputLayer.neurons[0].Sum) * error;

            // weights1
            double[] weightChanges1 = new double[net.HiddenLayer.neurons.Count];
            for (int i = 0; i < net.HiddenLayer.neurons.Count; i++)
            {
                weightChanges1[i] = net.HiddenLayer.neurons[i].Output * deltaOutputSum;
            }

            // hidden sum
            deltaHiddenSum = new double[net.OutputLayer.neurons[0].Input.Count]; // fix 0 .. hardcode shit
            for (int i = 0; i < net.HiddenLayer.neurons.Count; i++)
            {
                deltaHiddenSum[i] = deltaOutputSum * net.OutputLayer.neurons[0].Input[i].Weight * SigmoidDerivative(net.HiddenLayer.neurons[i].Sum);
            }

            // wieghts2
            int hiddenNeuronCount = 0;
            for (int i = 0; i < net.HiddenLayer.neurons.Count; i++)
            {
                hiddenNeuronCount += net.HiddenLayer.neurons[i].Input.Count;
            }
            // using the total weights count
            double[] weightChanges2 = new double[hiddenNeuronCount];
            int tempCount = 0;
            for (int i = 0; i < net.InputLayer.neurons.Count; i++)
            {
                for (int j = 0; j < deltaHiddenSum.Length; j++)
                {
                    weightChanges2[tempCount] = deltaHiddenSum[j] * net.InputLayer.neurons[i].Output;
                    tempCount++;
                }
            }

            // apply changes1
            tempCount = 0;
            for (int j = 0; j < weightChanges1.Length; j++)
            {
                for (int i = 0; i < net.OutputLayer.neurons.Count; i++)
                {
                    net.OutputLayer.neurons[i].Input[j].AdjustWeight(weightChanges1[tempCount]);
                    tempCount++;
                }
            }

            // apply changes2
            tempCount = 0;
            for (int i = 0; i < net.InputLayer.neurons.Count; i++)
            {
                for (int j = 0; j < net.HiddenLayer.neurons.Count; j++)
                {
                    net.HiddenLayer.neurons[j].Input[i].AdjustWeight(weightChanges2[tempCount]);
                    tempCount++;
                }
            }
        }

        private double SigmoidDerivative(double value)
        {
            return value * (1.0 - value);
        }
    }
}
