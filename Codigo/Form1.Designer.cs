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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.Location = new System.Drawing.Point(12, 13);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrenar.TabIndex = 0;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click);
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(12, 42);
            this.txtMonitor.Multiline = true;
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.ReadOnly = true;
            this.txtMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMonitor.Size = new System.Drawing.Size(747, 396);
            this.txtMonitor.TabIndex = 1;
            // 
            // txtSepalLength
            // 
            this.txtSepalLength.Location = new System.Drawing.Point(12, 483);
            this.txtSepalLength.Name = "txtSepalLength";
            this.txtSepalLength.Size = new System.Drawing.Size(100, 20);
            this.txtSepalLength.TabIndex = 2;
            // 
            // txtSepalWidth
            // 
            this.txtSepalWidth.Location = new System.Drawing.Point(118, 483);
            this.txtSepalWidth.Name = "txtSepalWidth";
            this.txtSepalWidth.Size = new System.Drawing.Size(100, 20);
            this.txtSepalWidth.TabIndex = 3;
            // 
            // txtPetalLength
            // 
            this.txtPetalLength.Location = new System.Drawing.Point(224, 483);
            this.txtPetalLength.Name = "txtPetalLength";
            this.txtPetalLength.Size = new System.Drawing.Size(100, 20);
            this.txtPetalLength.TabIndex = 4;
            // 
            // txtPetalWidth
            // 
            this.txtPetalWidth.Location = new System.Drawing.Point(330, 483);
            this.txtPetalWidth.Name = "txtPetalWidth";
            this.txtPetalWidth.Size = new System.Drawing.Size(100, 20);
            this.txtPetalWidth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sepal Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sepal Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Petal Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Petal Width";
            // 
            // btnPredecir
            // 
            this.btnPredecir.Enabled = false;
            this.btnPredecir.Location = new System.Drawing.Point(436, 481);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(75, 23);
            this.btnPredecir.TabIndex = 10;
            this.btnPredecir.Text = "Predecir";
            this.btnPredecir.UseVisualStyleBackColor = true;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(517, 483);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(236, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resultado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(93, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 537);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnPredecir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPetalWidth);
            this.Controls.Add(this.txtPetalLength);
            this.Controls.Add(this.txtSepalWidth);
            this.Controls.Add(this.txtSepalLength);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.btnEntrenar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iris";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
    }
}

