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
            this.button1 = new System.Windows.Forms.Button();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.txtSepalLength = new System.Windows.Forms.TextBox();
            this.txtSepalWidth = new System.Windows.Forms.TextBox();
            this.txtPetalLength = new System.Windows.Forms.TextBox();
            this.txtPetalWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(16, 52);
            this.txtMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonitor.Multiline = true;
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.ReadOnly = true;
            this.txtMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMonitor.Size = new System.Drawing.Size(995, 486);
            this.txtMonitor.TabIndex = 1;
            // 
            // txtSepalLength
            // 
            this.txtSepalLength.Location = new System.Drawing.Point(16, 594);
            this.txtSepalLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSepalLength.Name = "txtSepalLength";
            this.txtSepalLength.Size = new System.Drawing.Size(132, 22);
            this.txtSepalLength.TabIndex = 2;
            // 
            // txtSepalWidth
            // 
            this.txtSepalWidth.Location = new System.Drawing.Point(157, 594);
            this.txtSepalWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSepalWidth.Name = "txtSepalWidth";
            this.txtSepalWidth.Size = new System.Drawing.Size(132, 22);
            this.txtSepalWidth.TabIndex = 3;
            // 
            // txtPetalLength
            // 
            this.txtPetalLength.Location = new System.Drawing.Point(299, 594);
            this.txtPetalLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPetalLength.Name = "txtPetalLength";
            this.txtPetalLength.Size = new System.Drawing.Size(132, 22);
            this.txtPetalLength.TabIndex = 4;
            // 
            // txtPetalWidth
            // 
            this.txtPetalWidth.Location = new System.Drawing.Point(440, 594);
            this.txtPetalWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPetalWidth.Name = "txtPetalWidth";
            this.txtPetalWidth.Size = new System.Drawing.Size(132, 22);
            this.txtPetalWidth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 575);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sepal Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 575);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sepal Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 575);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Petal Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 575);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Petal Width";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 592);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Predecir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(689, 594);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(313, 22);
            this.txtResultado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 575);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resultado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 661);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPetalWidth);
            this.Controls.Add(this.txtPetalLength);
            this.Controls.Add(this.txtSepalWidth);
            this.Controls.Add(this.txtSepalLength);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.TextBox txtSepalLength;
        private System.Windows.Forms.TextBox txtSepalWidth;
        private System.Windows.Forms.TextBox txtPetalLength;
        private System.Windows.Forms.TextBox txtPetalWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}

