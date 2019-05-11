namespace IrisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.txtSepalLength = new System.Windows.Forms.TextBox();
            this.txtSepalWidth = new System.Windows.Forms.TextBox();
            this.txtPetalLength = new System.Windows.Forms.TextBox();
            this.txtPetalWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPredecir = new System.Windows.Forms.Button();
            this.txtSetosa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridParametrosAlgoritmoEntrenamiento = new System.Windows.Forms.PropertyGrid();
            this.label16 = new System.Windows.Forms.Label();
            this.spinDropout = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.spinIteraciones = new System.Windows.Forms.NumericUpDown();
            this.cboAlgoritmoEntrenamiento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboFuncionCosto = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboBiasSalida = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPesosSalida = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboFuncionActivacionSalida = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboBiasOculta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPesosOculta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFuncionActivacionOculta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spinNeuronasOculta = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVirginica = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVersicolor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDropout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIteraciones)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNeuronasOculta)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEntrenar.Location = new System.Drawing.Point(16, 246);
            this.btnEntrenar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(100, 28);
            this.btnEntrenar.TabIndex = 0;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = false;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click);
            // 
            // txtMonitor
            // 
            this.txtMonitor.BackColor = System.Drawing.Color.White;
            this.txtMonitor.Location = new System.Drawing.Point(16, 282);
            this.txtMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonitor.Multiline = true;
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.ReadOnly = true;
            this.txtMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMonitor.Size = new System.Drawing.Size(588, 238);
            this.txtMonitor.TabIndex = 1;
            // 
            // txtSepalLength
            // 
            this.txtSepalLength.Location = new System.Drawing.Point(8, 39);
            this.txtSepalLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtSepalLength.Name = "txtSepalLength";
            this.txtSepalLength.Size = new System.Drawing.Size(261, 22);
            this.txtSepalLength.TabIndex = 2;
            // 
            // txtSepalWidth
            // 
            this.txtSepalWidth.Location = new System.Drawing.Point(8, 94);
            this.txtSepalWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtSepalWidth.Name = "txtSepalWidth";
            this.txtSepalWidth.Size = new System.Drawing.Size(261, 22);
            this.txtSepalWidth.TabIndex = 3;
            // 
            // txtPetalLength
            // 
            this.txtPetalLength.Location = new System.Drawing.Point(8, 150);
            this.txtPetalLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtPetalLength.Name = "txtPetalLength";
            this.txtPetalLength.Size = new System.Drawing.Size(261, 22);
            this.txtPetalLength.TabIndex = 4;
            // 
            // txtPetalWidth
            // 
            this.txtPetalWidth.Location = new System.Drawing.Point(8, 204);
            this.txtPetalWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtPetalWidth.Name = "txtPetalWidth";
            this.txtPetalWidth.Size = new System.Drawing.Size(261, 22);
            this.txtPetalWidth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sepal Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sepal Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Petal Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Petal Width";
            // 
            // btnPredecir
            // 
            this.btnPredecir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPredecir.Enabled = false;
            this.btnPredecir.Location = new System.Drawing.Point(279, 37);
            this.btnPredecir.Margin = new System.Windows.Forms.Padding(4);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(259, 28);
            this.btnPredecir.TabIndex = 10;
            this.btnPredecir.Text = "Predecir";
            this.btnPredecir.UseVisualStyleBackColor = false;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // txtSetosa
            // 
            this.txtSetosa.Location = new System.Drawing.Point(279, 94);
            this.txtSetosa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSetosa.Name = "txtSetosa";
            this.txtSetosa.ReadOnly = true;
            this.txtSetosa.Size = new System.Drawing.Size(257, 22);
            this.txtSetosa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Setosa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(124, 246);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1175, 219);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiperparámetros";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.gridParametrosAlgoritmoEntrenamiento);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.spinDropout);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.spinIteraciones);
            this.groupBox4.Controls.Add(this.cboAlgoritmoEntrenamiento);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cboFuncionCosto);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(597, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(567, 187);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entrenamiento";
            // 
            // gridParametrosAlgoritmoEntrenamiento
            // 
            this.gridParametrosAlgoritmoEntrenamiento.CanShowVisualStyleGlyphs = false;
            this.gridParametrosAlgoritmoEntrenamiento.CommandsVisibleIfAvailable = false;
            this.gridParametrosAlgoritmoEntrenamiento.HelpVisible = false;
            this.gridParametrosAlgoritmoEntrenamiento.Location = new System.Drawing.Point(287, 77);
            this.gridParametrosAlgoritmoEntrenamiento.Name = "gridParametrosAlgoritmoEntrenamiento";
            this.gridParametrosAlgoritmoEntrenamiento.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.gridParametrosAlgoritmoEntrenamiento.Size = new System.Drawing.Size(269, 99);
            this.gridParametrosAlgoritmoEntrenamiento.TabIndex = 10;
            this.gridParametrosAlgoritmoEntrenamiento.ToolbarVisible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 134);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "Dropout";
            // 
            // spinDropout
            // 
            this.spinDropout.DecimalPlaces = 3;
            this.spinDropout.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.spinDropout.Location = new System.Drawing.Point(8, 154);
            this.spinDropout.Margin = new System.Windows.Forms.Padding(4);
            this.spinDropout.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            196608});
            this.spinDropout.Name = "spinDropout";
            this.spinDropout.Size = new System.Drawing.Size(269, 22);
            this.spinDropout.TabIndex = 8;
            this.spinDropout.Value = new decimal(new int[] {
            999,
            0,
            0,
            196608});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 82);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Iteraciones";
            // 
            // spinIteraciones
            // 
            this.spinIteraciones.Location = new System.Drawing.Point(8, 102);
            this.spinIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.spinIteraciones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spinIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinIteraciones.Name = "spinIteraciones";
            this.spinIteraciones.Size = new System.Drawing.Size(269, 22);
            this.spinIteraciones.TabIndex = 6;
            this.spinIteraciones.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // cboAlgoritmoEntrenamiento
            // 
            this.cboAlgoritmoEntrenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlgoritmoEntrenamiento.FormattingEnabled = true;
            this.cboAlgoritmoEntrenamiento.Location = new System.Drawing.Point(287, 46);
            this.cboAlgoritmoEntrenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.cboAlgoritmoEntrenamiento.Name = "cboAlgoritmoEntrenamiento";
            this.cboAlgoritmoEntrenamiento.Size = new System.Drawing.Size(269, 24);
            this.cboAlgoritmoEntrenamiento.TabIndex = 5;
            this.cboAlgoritmoEntrenamiento.SelectedIndexChanged += new System.EventHandler(this.cboAlgoritmoEntrenamiento_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Algoritmo";
            // 
            // cboFuncionCosto
            // 
            this.cboFuncionCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionCosto.FormattingEnabled = true;
            this.cboFuncionCosto.Location = new System.Drawing.Point(8, 46);
            this.cboFuncionCosto.Margin = new System.Windows.Forms.Padding(4);
            this.cboFuncionCosto.Name = "cboFuncionCosto";
            this.cboFuncionCosto.Size = new System.Drawing.Size(269, 24);
            this.cboFuncionCosto.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Función Costo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cboBiasSalida);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboPesosSalida);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cboFuncionActivacionSalida);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(303, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(287, 187);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Capa Salida";
            // 
            // cboBiasSalida
            // 
            this.cboBiasSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBiasSalida.FormattingEnabled = true;
            this.cboBiasSalida.Location = new System.Drawing.Point(8, 154);
            this.cboBiasSalida.Margin = new System.Windows.Forms.Padding(4);
            this.cboBiasSalida.Name = "cboBiasSalida";
            this.cboBiasSalida.Size = new System.Drawing.Size(269, 24);
            this.cboBiasSalida.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Modo Inicialización Bias";
            // 
            // cboPesosSalida
            // 
            this.cboPesosSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesosSalida.FormattingEnabled = true;
            this.cboPesosSalida.Location = new System.Drawing.Point(8, 102);
            this.cboPesosSalida.Margin = new System.Windows.Forms.Padding(4);
            this.cboPesosSalida.Name = "cboPesosSalida";
            this.cboPesosSalida.Size = new System.Drawing.Size(269, 24);
            this.cboPesosSalida.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Modo Inicialización Pesos";
            // 
            // cboFuncionActivacionSalida
            // 
            this.cboFuncionActivacionSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionActivacionSalida.FormattingEnabled = true;
            this.cboFuncionActivacionSalida.Location = new System.Drawing.Point(8, 46);
            this.cboFuncionActivacionSalida.Margin = new System.Windows.Forms.Padding(4);
            this.cboFuncionActivacionSalida.Name = "cboFuncionActivacionSalida";
            this.cboFuncionActivacionSalida.Size = new System.Drawing.Size(269, 24);
            this.cboFuncionActivacionSalida.TabIndex = 3;
            this.cboFuncionActivacionSalida.SelectedIndexChanged += new System.EventHandler(this.cboFuncionActivacionSalida_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Función Activación";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cboBiasOculta);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboPesosOculta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboFuncionActivacionOculta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.spinNeuronasOculta);
            this.groupBox2.Location = new System.Drawing.Point(8, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(287, 187);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capa Oculta";
            // 
            // cboBiasOculta
            // 
            this.cboBiasOculta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBiasOculta.FormattingEnabled = true;
            this.cboBiasOculta.Location = new System.Drawing.Point(8, 154);
            this.cboBiasOculta.Margin = new System.Windows.Forms.Padding(4);
            this.cboBiasOculta.Name = "cboBiasOculta";
            this.cboBiasOculta.Size = new System.Drawing.Size(269, 24);
            this.cboBiasOculta.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Modo Inicialización Bias";
            // 
            // cboPesosOculta
            // 
            this.cboPesosOculta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesosOculta.FormattingEnabled = true;
            this.cboPesosOculta.Location = new System.Drawing.Point(8, 102);
            this.cboPesosOculta.Margin = new System.Windows.Forms.Padding(4);
            this.cboPesosOculta.Name = "cboPesosOculta";
            this.cboPesosOculta.Size = new System.Drawing.Size(269, 24);
            this.cboPesosOculta.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Modo Inicialización Pesos";
            // 
            // cboFuncionActivacionOculta
            // 
            this.cboFuncionActivacionOculta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionActivacionOculta.FormattingEnabled = true;
            this.cboFuncionActivacionOculta.Location = new System.Drawing.Point(112, 46);
            this.cboFuncionActivacionOculta.Margin = new System.Windows.Forms.Padding(4);
            this.cboFuncionActivacionOculta.Name = "cboFuncionActivacionOculta";
            this.cboFuncionActivacionOculta.Size = new System.Drawing.Size(165, 24);
            this.cboFuncionActivacionOculta.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Función Activación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Neuronas";
            // 
            // spinNeuronasOculta
            // 
            this.spinNeuronasOculta.Location = new System.Drawing.Point(8, 47);
            this.spinNeuronasOculta.Margin = new System.Windows.Forms.Padding(4);
            this.spinNeuronasOculta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNeuronasOculta.Name = "spinNeuronasOculta";
            this.spinNeuronasOculta.Size = new System.Drawing.Size(96, 22);
            this.spinNeuronasOculta.TabIndex = 0;
            this.spinNeuronasOculta.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txtVirginica);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtVersicolor);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtSepalLength);
            this.groupBox5.Controls.Add(this.txtSepalWidth);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtPetalLength);
            this.groupBox5.Controls.Add(this.txtSetosa);
            this.groupBox5.Controls.Add(this.txtPetalWidth);
            this.groupBox5.Controls.Add(this.btnPredecir);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(621, 282);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(569, 239);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Predicción";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 185);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = "Virgínica";
            // 
            // txtVirginica
            // 
            this.txtVirginica.Location = new System.Drawing.Point(279, 204);
            this.txtVirginica.Margin = new System.Windows.Forms.Padding(4);
            this.txtVirginica.Name = "txtVirginica";
            this.txtVirginica.ReadOnly = true;
            this.txtVirginica.Size = new System.Drawing.Size(257, 22);
            this.txtVirginica.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(275, 130);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Versicolor";
            // 
            // txtVersicolor
            // 
            this.txtVersicolor.Location = new System.Drawing.Point(279, 150);
            this.txtVersicolor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVersicolor.Name = "txtVersicolor";
            this.txtVersicolor.ReadOnly = true;
            this.txtVersicolor.Size = new System.Drawing.Size(257, 22);
            this.txtVersicolor.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 534);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.btnEntrenar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDropout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIteraciones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNeuronasOculta)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.TextBox txtSepalLength;
        private System.Windows.Forms.TextBox txtSepalWidth;
        private System.Windows.Forms.TextBox txtPetalLength;
        private System.Windows.Forms.TextBox txtPetalWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPredecir;
        private System.Windows.Forms.TextBox txtSetosa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboFuncionActivacionOculta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spinNeuronasOculta;
        private System.Windows.Forms.ComboBox cboBiasOculta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPesosOculta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboBiasSalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPesosSalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboFuncionActivacionSalida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboFuncionCosto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboAlgoritmoEntrenamiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown spinIteraciones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown spinDropout;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtVirginica;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVersicolor;
        private System.Windows.Forms.PropertyGrid gridParametrosAlgoritmoEntrenamiento;
    }
}

