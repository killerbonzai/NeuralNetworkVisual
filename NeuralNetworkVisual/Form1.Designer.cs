namespace NeuralNetworkVisual
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOutputSum = new System.Windows.Forms.Label();
            this.lblOutputOutput = new System.Windows.Forms.Label();
            this.lblOutputW0 = new System.Windows.Forms.Label();
            this.lblOutputW1 = new System.Windows.Forms.Label();
            this.lblOutputW2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHidden0W1 = new System.Windows.Forms.Label();
            this.lblHidden0W0 = new System.Windows.Forms.Label();
            this.lblHidden0Output = new System.Windows.Forms.Label();
            this.lblHidden0Sum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHidden1W1 = new System.Windows.Forms.Label();
            this.lblHidden1W0 = new System.Windows.Forms.Label();
            this.lblHidden1Output = new System.Windows.Forms.Label();
            this.lblHidden1Sum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblHidden2W1 = new System.Windows.Forms.Label();
            this.lblHidden2W0 = new System.Windows.Forms.Label();
            this.lblHidden2Output = new System.Windows.Forms.Label();
            this.lblHidden2Sum = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblHidden3W1 = new System.Windows.Forms.Label();
            this.lblHidden3W0 = new System.Windows.Forms.Label();
            this.lblHidden3Output = new System.Windows.Forms.Label();
            this.lblHidden3Sum = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblInput0Output = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblInput1Output = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHidden0Bias = new System.Windows.Forms.Label();
            this.lblHidden1Bias = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHidden2Bias = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblHidden3Bias = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnInitNetwork = new System.Windows.Forms.Button();
            this.btnPulse = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.cmbDataSet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblExpected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOutputW2);
            this.groupBox1.Controls.Add(this.lblOutputW1);
            this.groupBox1.Controls.Add(this.lblOutputW0);
            this.groupBox1.Controls.Add(this.lblOutputOutput);
            this.groupBox1.Controls.Add(this.lblOutputSum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(867, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OutputNeuron";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight2";
            // 
            // lblOutputSum
            // 
            this.lblOutputSum.AutoSize = true;
            this.lblOutputSum.Location = new System.Drawing.Point(143, 40);
            this.lblOutputSum.Name = "lblOutputSum";
            this.lblOutputSum.Size = new System.Drawing.Size(28, 13);
            this.lblOutputSum.TabIndex = 5;
            this.lblOutputSum.Text = "Sum";
            // 
            // lblOutputOutput
            // 
            this.lblOutputOutput.AutoSize = true;
            this.lblOutputOutput.Location = new System.Drawing.Point(169, 141);
            this.lblOutputOutput.Name = "lblOutputOutput";
            this.lblOutputOutput.Size = new System.Drawing.Size(28, 13);
            this.lblOutputOutput.TabIndex = 6;
            this.lblOutputOutput.Text = "Sum";
            // 
            // lblOutputW0
            // 
            this.lblOutputW0.AutoSize = true;
            this.lblOutputW0.Location = new System.Drawing.Point(6, 63);
            this.lblOutputW0.Name = "lblOutputW0";
            this.lblOutputW0.Size = new System.Drawing.Size(28, 13);
            this.lblOutputW0.TabIndex = 7;
            this.lblOutputW0.Text = "Sum";
            // 
            // lblOutputW1
            // 
            this.lblOutputW1.AutoSize = true;
            this.lblOutputW1.Location = new System.Drawing.Point(6, 109);
            this.lblOutputW1.Name = "lblOutputW1";
            this.lblOutputW1.Size = new System.Drawing.Size(28, 13);
            this.lblOutputW1.TabIndex = 8;
            this.lblOutputW1.Text = "Sum";
            // 
            // lblOutputW2
            // 
            this.lblOutputW2.AutoSize = true;
            this.lblOutputW2.Location = new System.Drawing.Point(6, 163);
            this.lblOutputW2.Name = "lblOutputW2";
            this.lblOutputW2.Size = new System.Drawing.Size(28, 13);
            this.lblOutputW2.TabIndex = 9;
            this.lblOutputW2.Text = "Sum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHidden0Bias);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblHidden0W1);
            this.groupBox2.Controls.Add(this.lblHidden0W0);
            this.groupBox2.Controls.Add(this.lblHidden0Output);
            this.groupBox2.Controls.Add(this.lblHidden0Sum);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(425, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HiddenNeuron0";
            // 
            // lblHidden0W1
            // 
            this.lblHidden0W1.AutoSize = true;
            this.lblHidden0W1.Location = new System.Drawing.Point(6, 81);
            this.lblHidden0W1.Name = "lblHidden0W1";
            this.lblHidden0W1.Size = new System.Drawing.Size(28, 13);
            this.lblHidden0W1.TabIndex = 8;
            this.lblHidden0W1.Text = "Sum";
            // 
            // lblHidden0W0
            // 
            this.lblHidden0W0.AutoSize = true;
            this.lblHidden0W0.Location = new System.Drawing.Point(6, 40);
            this.lblHidden0W0.Name = "lblHidden0W0";
            this.lblHidden0W0.Size = new System.Drawing.Size(28, 13);
            this.lblHidden0W0.TabIndex = 7;
            this.lblHidden0W0.Text = "Sum";
            // 
            // lblHidden0Output
            // 
            this.lblHidden0Output.AutoSize = true;
            this.lblHidden0Output.Location = new System.Drawing.Point(182, 81);
            this.lblHidden0Output.Name = "lblHidden0Output";
            this.lblHidden0Output.Size = new System.Drawing.Size(28, 13);
            this.lblHidden0Output.TabIndex = 6;
            this.lblHidden0Output.Text = "Sum";
            // 
            // lblHidden0Sum
            // 
            this.lblHidden0Sum.AutoSize = true;
            this.lblHidden0Sum.Location = new System.Drawing.Point(152, 40);
            this.lblHidden0Sum.Name = "lblHidden0Sum";
            this.lblHidden0Sum.Size = new System.Drawing.Size(28, 13);
            this.lblHidden0Sum.TabIndex = 5;
            this.lblHidden0Sum.Text = "Sum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Weight1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Weight0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Output";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(152, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Sum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblHidden1Bias);
            this.groupBox3.Controls.Add(this.lblHidden1W1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblHidden1W0);
            this.groupBox3.Controls.Add(this.lblHidden1Output);
            this.groupBox3.Controls.Add(this.lblHidden1Sum);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(425, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 114);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HiddenNeuron1";
            // 
            // lblHidden1W1
            // 
            this.lblHidden1W1.AutoSize = true;
            this.lblHidden1W1.Location = new System.Drawing.Point(6, 81);
            this.lblHidden1W1.Name = "lblHidden1W1";
            this.lblHidden1W1.Size = new System.Drawing.Size(28, 13);
            this.lblHidden1W1.TabIndex = 8;
            this.lblHidden1W1.Text = "Sum";
            // 
            // lblHidden1W0
            // 
            this.lblHidden1W0.AutoSize = true;
            this.lblHidden1W0.Location = new System.Drawing.Point(6, 40);
            this.lblHidden1W0.Name = "lblHidden1W0";
            this.lblHidden1W0.Size = new System.Drawing.Size(28, 13);
            this.lblHidden1W0.TabIndex = 7;
            this.lblHidden1W0.Text = "Sum";
            // 
            // lblHidden1Output
            // 
            this.lblHidden1Output.AutoSize = true;
            this.lblHidden1Output.Location = new System.Drawing.Point(182, 81);
            this.lblHidden1Output.Name = "lblHidden1Output";
            this.lblHidden1Output.Size = new System.Drawing.Size(28, 13);
            this.lblHidden1Output.TabIndex = 6;
            this.lblHidden1Output.Text = "Sum";
            // 
            // lblHidden1Sum
            // 
            this.lblHidden1Sum.AutoSize = true;
            this.lblHidden1Sum.Location = new System.Drawing.Point(152, 40);
            this.lblHidden1Sum.Name = "lblHidden1Sum";
            this.lblHidden1Sum.Size = new System.Drawing.Size(28, 13);
            this.lblHidden1Sum.TabIndex = 5;
            this.lblHidden1Sum.Text = "Sum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Weight1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Weight0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(182, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Output";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(152, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Sum";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblHidden2Bias);
            this.groupBox4.Controls.Add(this.lblHidden2W1);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblHidden2W0);
            this.groupBox4.Controls.Add(this.lblHidden2Output);
            this.groupBox4.Controls.Add(this.lblHidden2Sum);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Location = new System.Drawing.Point(425, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 114);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HiddenNeuron2";
            // 
            // lblHidden2W1
            // 
            this.lblHidden2W1.AutoSize = true;
            this.lblHidden2W1.Location = new System.Drawing.Point(6, 81);
            this.lblHidden2W1.Name = "lblHidden2W1";
            this.lblHidden2W1.Size = new System.Drawing.Size(28, 13);
            this.lblHidden2W1.TabIndex = 8;
            this.lblHidden2W1.Text = "Sum";
            // 
            // lblHidden2W0
            // 
            this.lblHidden2W0.AutoSize = true;
            this.lblHidden2W0.Location = new System.Drawing.Point(6, 40);
            this.lblHidden2W0.Name = "lblHidden2W0";
            this.lblHidden2W0.Size = new System.Drawing.Size(28, 13);
            this.lblHidden2W0.TabIndex = 7;
            this.lblHidden2W0.Text = "Sum";
            // 
            // lblHidden2Output
            // 
            this.lblHidden2Output.AutoSize = true;
            this.lblHidden2Output.Location = new System.Drawing.Point(182, 81);
            this.lblHidden2Output.Name = "lblHidden2Output";
            this.lblHidden2Output.Size = new System.Drawing.Size(28, 13);
            this.lblHidden2Output.TabIndex = 6;
            this.lblHidden2Output.Text = "Sum";
            // 
            // lblHidden2Sum
            // 
            this.lblHidden2Sum.AutoSize = true;
            this.lblHidden2Sum.Location = new System.Drawing.Point(152, 40);
            this.lblHidden2Sum.Name = "lblHidden2Sum";
            this.lblHidden2Sum.Size = new System.Drawing.Size(28, 13);
            this.lblHidden2Sum.TabIndex = 5;
            this.lblHidden2Sum.Text = "Sum";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Weight1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Weight0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(182, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Output";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(152, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Sum";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblHidden3Bias);
            this.groupBox5.Controls.Add(this.lblHidden3W1);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.lblHidden3W0);
            this.groupBox5.Controls.Add(this.lblHidden3Output);
            this.groupBox5.Controls.Add(this.lblHidden3Sum);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Location = new System.Drawing.Point(425, 391);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 114);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HiddenNeuron3";
            // 
            // lblHidden3W1
            // 
            this.lblHidden3W1.AutoSize = true;
            this.lblHidden3W1.Location = new System.Drawing.Point(6, 81);
            this.lblHidden3W1.Name = "lblHidden3W1";
            this.lblHidden3W1.Size = new System.Drawing.Size(28, 13);
            this.lblHidden3W1.TabIndex = 8;
            this.lblHidden3W1.Text = "Sum";
            // 
            // lblHidden3W0
            // 
            this.lblHidden3W0.AutoSize = true;
            this.lblHidden3W0.Location = new System.Drawing.Point(6, 40);
            this.lblHidden3W0.Name = "lblHidden3W0";
            this.lblHidden3W0.Size = new System.Drawing.Size(28, 13);
            this.lblHidden3W0.TabIndex = 7;
            this.lblHidden3W0.Text = "Sum";
            // 
            // lblHidden3Output
            // 
            this.lblHidden3Output.AutoSize = true;
            this.lblHidden3Output.Location = new System.Drawing.Point(182, 81);
            this.lblHidden3Output.Name = "lblHidden3Output";
            this.lblHidden3Output.Size = new System.Drawing.Size(28, 13);
            this.lblHidden3Output.TabIndex = 6;
            this.lblHidden3Output.Text = "Sum";
            // 
            // lblHidden3Sum
            // 
            this.lblHidden3Sum.AutoSize = true;
            this.lblHidden3Sum.Location = new System.Drawing.Point(152, 40);
            this.lblHidden3Sum.Name = "lblHidden3Sum";
            this.lblHidden3Sum.Size = new System.Drawing.Size(28, 13);
            this.lblHidden3Sum.TabIndex = 5;
            this.lblHidden3Sum.Text = "Sum";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Weight1";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 27);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Weight0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(182, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "Output";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(152, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(28, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "Sum";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblInput0Output);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Location = new System.Drawing.Point(85, 112);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 114);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "InputNeuron0";
            // 
            // lblInput0Output
            // 
            this.lblInput0Output.AutoSize = true;
            this.lblInput0Output.Location = new System.Drawing.Point(153, 81);
            this.lblInput0Output.Name = "lblInput0Output";
            this.lblInput0Output.Size = new System.Drawing.Size(28, 13);
            this.lblInput0Output.TabIndex = 6;
            this.lblInput0Output.Text = "Sum";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(153, 68);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(39, 13);
            this.label40.TabIndex = 1;
            this.label40.Text = "Output";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblInput1Output);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Location = new System.Drawing.Point(85, 311);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 114);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "InputNeuron1";
            // 
            // lblInput1Output
            // 
            this.lblInput1Output.AutoSize = true;
            this.lblInput1Output.Location = new System.Drawing.Point(153, 81);
            this.lblInput1Output.Name = "lblInput1Output";
            this.lblInput1Output.Size = new System.Drawing.Size(28, 13);
            this.lblInput1Output.TabIndex = 6;
            this.lblInput1Output.Text = "Sum";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(153, 68);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(39, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bias";
            // 
            // lblHidden0Bias
            // 
            this.lblHidden0Bias.AutoSize = true;
            this.lblHidden0Bias.Location = new System.Drawing.Point(301, 29);
            this.lblHidden0Bias.Name = "lblHidden0Bias";
            this.lblHidden0Bias.Size = new System.Drawing.Size(27, 13);
            this.lblHidden0Bias.TabIndex = 10;
            this.lblHidden0Bias.Text = "Bias";
            // 
            // lblHidden1Bias
            // 
            this.lblHidden1Bias.AutoSize = true;
            this.lblHidden1Bias.Location = new System.Drawing.Point(301, 29);
            this.lblHidden1Bias.Name = "lblHidden1Bias";
            this.lblHidden1Bias.Size = new System.Drawing.Size(27, 13);
            this.lblHidden1Bias.TabIndex = 12;
            this.lblHidden1Bias.Text = "Bias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bias";
            // 
            // lblHidden2Bias
            // 
            this.lblHidden2Bias.AutoSize = true;
            this.lblHidden2Bias.Location = new System.Drawing.Point(301, 29);
            this.lblHidden2Bias.Name = "lblHidden2Bias";
            this.lblHidden2Bias.Size = new System.Drawing.Size(27, 13);
            this.lblHidden2Bias.TabIndex = 14;
            this.lblHidden2Bias.Text = "Bias";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(301, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Bias";
            // 
            // lblHidden3Bias
            // 
            this.lblHidden3Bias.AutoSize = true;
            this.lblHidden3Bias.Location = new System.Drawing.Point(301, 29);
            this.lblHidden3Bias.Name = "lblHidden3Bias";
            this.lblHidden3Bias.Size = new System.Drawing.Size(27, 13);
            this.lblHidden3Bias.TabIndex = 16;
            this.lblHidden3Bias.Text = "Bias";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(301, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Bias";
            // 
            // btnInitNetwork
            // 
            this.btnInitNetwork.Location = new System.Drawing.Point(12, 12);
            this.btnInitNetwork.Name = "btnInitNetwork";
            this.btnInitNetwork.Size = new System.Drawing.Size(89, 23);
            this.btnInitNetwork.TabIndex = 12;
            this.btnInitNetwork.Text = "New network";
            this.btnInitNetwork.UseVisualStyleBackColor = true;
            this.btnInitNetwork.Click += new System.EventHandler(this.btnInitNetwork_Click);
            // 
            // btnPulse
            // 
            this.btnPulse.Location = new System.Drawing.Point(107, 12);
            this.btnPulse.Name = "btnPulse";
            this.btnPulse.Size = new System.Drawing.Size(75, 23);
            this.btnPulse.TabIndex = 13;
            this.btnPulse.Text = "Pulse";
            this.btnPulse.UseVisualStyleBackColor = true;
            this.btnPulse.Click += new System.EventHandler(this.btnPulse_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(188, 12);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 14;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // cmbDataSet
            // 
            this.cmbDataSet.FormattingEnabled = true;
            this.cmbDataSet.Location = new System.Drawing.Point(974, 44);
            this.cmbDataSet.Name = "cmbDataSet";
            this.cmbDataSet.Size = new System.Drawing.Size(121, 21);
            this.cmbDataSet.TabIndex = 16;
            this.cmbDataSet.SelectedIndexChanged += new System.EventHandler(this.cmbDataSet_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(971, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "DataSet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1036, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Expected output:";
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Location = new System.Drawing.Point(1130, 395);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(37, 13);
            this.lblExpected.TabIndex = 19;
            this.lblExpected.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 579);
            this.Controls.Add(this.lblExpected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDataSet);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnPulse);
            this.Controls.Add(this.btnInitNetwork);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOutputW2;
        private System.Windows.Forms.Label lblOutputW1;
        private System.Windows.Forms.Label lblOutputW0;
        private System.Windows.Forms.Label lblOutputOutput;
        private System.Windows.Forms.Label lblOutputSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHidden0W1;
        private System.Windows.Forms.Label lblHidden0W0;
        private System.Windows.Forms.Label lblHidden0Output;
        private System.Windows.Forms.Label lblHidden0Sum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblHidden1W1;
        private System.Windows.Forms.Label lblHidden1W0;
        private System.Windows.Forms.Label lblHidden1Output;
        private System.Windows.Forms.Label lblHidden1Sum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblHidden2W1;
        private System.Windows.Forms.Label lblHidden2W0;
        private System.Windows.Forms.Label lblHidden2Output;
        private System.Windows.Forms.Label lblHidden2Sum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblHidden3W1;
        private System.Windows.Forms.Label lblHidden3W0;
        private System.Windows.Forms.Label lblHidden3Output;
        private System.Windows.Forms.Label lblHidden3Sum;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblInput0Output;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblInput1Output;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblHidden0Bias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHidden1Bias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHidden2Bias;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblHidden3Bias;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnInitNetwork;
        private System.Windows.Forms.Button btnPulse;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.ComboBox cmbDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblExpected;
    }
}

