using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralInterface;

namespace NeuralNetworkVisual
{
    public partial class Form1 : Form
    {
        NeuralNet net = new NeuralNet();
        Training trainy = new Training();
        Random rando = new Random();
        List<NetworkData> saveddata = new List<NetworkData>();
        int TotalTrainingSessions = 0;

        public Form1()
        {
            InitializeComponent();
            cmbDataSet.DisplayMember = "Name";
        }

        private void StartNewNetwork()
        {
            net.Init(5, 2, 4, 1);
        }

        private void PulseThrough()
        {
            net.Pulse();
        }

        int Localsession = 0;
        private void TrainNetwork()
        {
            double high = .9;
            double low = .1;

            double[][] input = new double[4][];
            input[0] = new double[] { high, high }; // 11 = false
            input[1] = new double[] { high, low }; // 10 = true
            input[2] = new double[] { low, high }; // 01 = true
            input[3] = new double[] { low, low }; // 00 = false

            double[] output = new double[4];
            output[0] = low;
            output[1] = high;
            output[2] = high;
            output[3] = low;

            net.InputLayer.neurons[0].SetOutput(input[Localsession][0]);
            net.InputLayer.neurons[1].SetOutput(input[Localsession][1]);
            
            PulseThrough();

            trainy.Train(output[Localsession], net);

            if (Localsession < 3)
            {
                Localsession++;
            }
            else
            {
                Localsession = 0;
            }

            TotalTrainingSessions++;
            FillOutLabelsFromData(SaveDataToList());
            lblExpected.Text = output[Localsession].ToString();
        }

        private void Run()
        {
            int seed = 5;

            net.Init(seed, 2, 4, 1); // 2 input, 4 hidden, 1 output

            double high = .9;
            double low = .1;

            double[][] input = new double[4][];
            input[0] = new double[] { high, high }; // 11 = false
            input[1] = new double[] { high, low }; // 10 = true
            input[2] = new double[] { low, high }; // 01 = true
            input[3] = new double[] { low, low }; // 00 = false

            double[] output = new double[4];
            output[0] = low;
            output[1] = high;
            output[2] = high;
            output[3] = low;

            for (int i = 0; i < 10; i++)
            {
                PrintOut(0.01, 0.9, 0.9); //true
                PrintOut(0.9, 0.01, 0.9); //true
                PrintOut(0.01, 0.01, 0.01); //false
                PrintOut(0.9, 0.9, 0.01); //false
            }

            Console.ReadKey();
        }

        private bool PrintOut(double input1, double input2, double target)
        {
            bool result;

            net.InputLayer.neurons[0].SetOutput(input1);
            net.InputLayer.neurons[1].SetOutput(input2);

            net.Pulse();

            Console.WriteLine("Before training");
            ShowMeWhatYouGot();
            double output = net.OutputLayer.neurons[0].GetOutput();
            result = output > .5;

            //Console.WriteLine("Input: " + input1 + " " + input2);
            Console.WriteLine("The actual result: " + result.ToString());
            Console.WriteLine(output);

            trainy.Train(target, net);
            net.Pulse();
            Console.WriteLine("After training");
            ShowMeWhatYouGot();

            output = net.OutputLayer.neurons[0].GetOutput();
            result = output > .5;

            //Console.WriteLine("Input: " + input1 + " " + input2);
            Console.WriteLine("The actual result: " + result.ToString());
            Console.WriteLine(output);

            Console.ReadKey();
            return result;
        }

        private void ShowMeWhatYouGot()
        {
            for (int i = 0; i < net.InputLayer.neurons.Count; i++)
            {
                Console.WriteLine("Input " + i + ": " + net.InputLayer.neurons[i].Output);
            }
            for (int i = 0; i < net.HiddenLayer.neurons.Count; i++)
            {
                for (int j = 0; j < net.HiddenLayer.neurons[i].Input.Count; j++)
                {
                    Console.WriteLine("Weight H" + i.ToString() + "I" + j.ToString() + ": " + net.HiddenLayer.neurons[i].Input[j].Weight);
                }
            }
            for (int i = 0; i < net.HiddenLayer.neurons.Count; i++)
            {
                Console.WriteLine("Hidden neuron " + i + ": " + net.HiddenLayer.neurons[i].Output);
            }
            for (int i = 0; i < net.OutputLayer.neurons.Count; i++)
            {
                Console.WriteLine("Output neuron " + i + ": " + net.OutputLayer.neurons[i].Output);
            }
        }

        private void FillOutLabelsFromData(NetworkData data)
        {
            // input labels
            lblInput0Output.Text = data.Input0.ToString();
            lblInput1Output.Text = data.Input1.ToString();

            // hiden labels
            lblHidden0Bias.Text = data.HiddenNeurons[0].Bias.ToString();
            lblHidden1Bias.Text = data.HiddenNeurons[1].Bias.ToString();
            lblHidden2Bias.Text = data.HiddenNeurons[2].Bias.ToString();
            lblHidden3Bias.Text = data.HiddenNeurons[3].Bias.ToString();

            lblHidden0Output.Text = data.HiddenNeurons[0].Output.ToString();
            lblHidden1Output.Text = data.HiddenNeurons[1].Output.ToString();
            lblHidden2Output.Text = data.HiddenNeurons[2].Output.ToString();
            lblHidden3Output.Text = data.HiddenNeurons[3].Output.ToString();

            lblHidden0Sum.Text = data.HiddenNeurons[0].Sum.ToString();
            lblHidden1Sum.Text = data.HiddenNeurons[1].Sum.ToString();
            lblHidden2Sum.Text = data.HiddenNeurons[2].Sum.ToString();
            lblHidden3Sum.Text = data.HiddenNeurons[3].Sum.ToString();
            // hidden W0
            lblHidden0W0.Text = data.HiddenNeurons[0].Weight0.ToString();
            lblHidden0W1.Text = data.HiddenNeurons[0].Weight1.ToString();
            // hidden W1
            lblHidden1W0.Text = data.HiddenNeurons[1].Weight0.ToString();
            lblHidden1W1.Text = data.HiddenNeurons[1].Weight1.ToString();
            // hidden W2
            lblHidden2W0.Text = data.HiddenNeurons[2].Weight0.ToString();
            lblHidden2W1.Text = data.HiddenNeurons[2].Weight1.ToString();
            // hidden W3
            lblHidden3W0.Text = data.HiddenNeurons[3].Weight0.ToString();
            lblHidden3W1.Text = data.HiddenNeurons[3].Weight1.ToString();

            // output labels
            lblOutputSum.Text = data.OutputNeuron.Sum.ToString();
            lblOutputOutput.Text = data.OutputNeuron.Output.ToString();
            lblOutputW0.Text = data.OutputNeuron.Weight0.ToString();
            lblOutputW1.Text = data.OutputNeuron.Weight1.ToString();
            lblOutputW2.Text = data.OutputNeuron.Weight2.ToString();
        }

        private NetworkData SaveDataToList()
        {
            NetworkData nd = new NetworkData();
            // input data
            nd.Input0 = net.InputLayer.neurons[0].Output;
            nd.Input1 = net.InputLayer.neurons[1].Output;

            // hidden data
            Data hiddenN0 = new Data();
            Data hiddenN1 = new Data();
            Data hiddenN2 = new Data();
            Data hiddenN3 = new Data();
            // bias
            hiddenN0.Bias = net.HiddenLayer.neurons[0].Bias;
            hiddenN1.Bias = net.HiddenLayer.neurons[1].Bias;
            hiddenN2.Bias = net.HiddenLayer.neurons[2].Bias;
            hiddenN3.Bias = net.HiddenLayer.neurons[3].Bias;
            // sum
            hiddenN0.Sum = net.HiddenLayer.neurons[0].Sum;
            hiddenN1.Sum = net.HiddenLayer.neurons[1].Sum;
            hiddenN2.Sum = net.HiddenLayer.neurons[2].Sum;
            hiddenN3.Sum = net.HiddenLayer.neurons[3].Sum;
            // output
            hiddenN0.Output = net.HiddenLayer.neurons[0].Output;
            hiddenN1.Output = net.HiddenLayer.neurons[1].Output;
            hiddenN2.Output = net.HiddenLayer.neurons[2].Output;
            hiddenN3.Output = net.HiddenLayer.neurons[3].Output;
            // hidden n0
            hiddenN0.Weight0 = net.HiddenLayer.neurons[0].Input[0].Weight;
            hiddenN0.Weight1 = net.HiddenLayer.neurons[0].Input[1].Weight;
            // hidden n1
            hiddenN1.Weight0 = net.HiddenLayer.neurons[1].Input[0].Weight;
            hiddenN1.Weight1 = net.HiddenLayer.neurons[1].Input[1].Weight;
            // hidden n2
            hiddenN2.Weight0 = net.HiddenLayer.neurons[2].Input[0].Weight;
            hiddenN2.Weight1 = net.HiddenLayer.neurons[2].Input[1].Weight;
            // hidden n3
            hiddenN3.Weight0 = net.HiddenLayer.neurons[3].Input[0].Weight;
            hiddenN3.Weight1 = net.HiddenLayer.neurons[3].Input[1].Weight;

            nd.HiddenNeurons = new List<Data>();
            nd.HiddenNeurons.Add(hiddenN0);
            nd.HiddenNeurons.Add(hiddenN1);
            nd.HiddenNeurons.Add(hiddenN2);
            nd.HiddenNeurons.Add(hiddenN3);

            // output labels
            Data output = new Data();
            output.Output = net.OutputLayer.neurons[0].Output;
            output.Sum = net.OutputLayer.neurons[0].Sum;
            output.Weight0 = net.OutputLayer.neurons[0].Input[0].Weight;
            output.Weight1 = net.OutputLayer.neurons[0].Input[1].Weight;
            output.Weight2 = net.OutputLayer.neurons[0].Input[2].Weight;
            nd.OutputNeuron = output;

            nd.Name = "Session #" + TotalTrainingSessions.ToString();

            saveddata.Add(nd);

            cmbDataSet.Items.Add(nd);

            return nd;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainNetwork();
        }

        private void btnPulse_Click(object sender, EventArgs e)
        {
            PulseThrough();
        }

        private void btnInitNetwork_Click(object sender, EventArgs e)
        {
            cmbDataSet.Items.Clear();
            StartNewNetwork();
        }

        private void cmbDataSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillOutLabelsFromData((NetworkData)cmbDataSet.SelectedItem);
        }
    }
}
