namespace PrjCalcCientifica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.rdoBin = new System.Windows.Forms.RadioButton();
            this.rdoDec = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(48, 21);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(222, 59);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSeno
            // 
            this.btnSeno.Location = new System.Drawing.Point(42, 180);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(53, 42);
            this.btnSeno.TabIndex = 1;
            this.btnSeno.Text = "Sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.BtnSeno_Click);
            // 
            // btnCoseno
            // 
            this.btnCoseno.Location = new System.Drawing.Point(101, 180);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(51, 42);
            this.btnCoseno.TabIndex = 2;
            this.btnCoseno.Text = "Cos";
            this.btnCoseno.UseVisualStyleBackColor = true;
            this.btnCoseno.Click += new System.EventHandler(this.BtnCoseno_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(158, 180);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(53, 41);
            this.btnInverter.TabIndex = 3;
            this.btnInverter.Text = "+/-";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.BtnInverter_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(217, 180);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(49, 42);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(38, 241);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 39);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(101, 241);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 39);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(158, 241);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 39);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(217, 241);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(49, 39);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(38, 298);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 44);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(158, 298);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 44);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(101, 298);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 44);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(217, 298);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(49, 44);
            this.btnSubtrair.TabIndex = 12;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(38, 359);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 39);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(101, 359);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 39);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(158, 359);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 39);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(217, 359);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(49, 39);
            this.btnSoma.TabIndex = 16;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 46);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(101, 414);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(51, 46);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(158, 414);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(53, 46);
            this.btnPonto.TabIndex = 19;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.BtnPonto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(217, 414);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(49, 46);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(42, 128);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(228, 46);
            this.btnBackspace.TabIndex = 21;
            this.btnBackspace.Text = "<-";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // rdoBin
            // 
            this.rdoBin.AutoSize = true;
            this.rdoBin.Location = new System.Drawing.Point(72, 93);
            this.rdoBin.Name = "rdoBin";
            this.rdoBin.Size = new System.Drawing.Size(57, 17);
            this.rdoBin.TabIndex = 22;
            this.rdoBin.TabStop = true;
            this.rdoBin.Text = "Binário";
            this.rdoBin.UseVisualStyleBackColor = true;
            this.rdoBin.CheckedChanged += new System.EventHandler(this.rdoBin_CheckedChanged);
            // 
            // rdoDec
            // 
            this.rdoDec.AutoSize = true;
            this.rdoDec.Location = new System.Drawing.Point(175, 93);
            this.rdoDec.Name = "rdoDec";
            this.rdoDec.Size = new System.Drawing.Size(63, 17);
            this.rdoDec.TabIndex = 23;
            this.rdoDec.TabStop = true;
            this.rdoDec.Text = "Decimal";
            this.rdoDec.UseVisualStyleBackColor = true;
            this.rdoDec.CheckedChanged += new System.EventHandler(this.rdoDec_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 508);
            this.Controls.Add(this.rdoDec);
            this.Controls.Add(this.rdoBin);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnCoseno);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.RadioButton rdoBin;
        private System.Windows.Forms.RadioButton rdoDec;
    }
}

