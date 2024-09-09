using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCalcCientifica
{
    public partial class Form1 : Form
    {

        Double v1 = 0.0;
        String op = "";
        private bool converte = false;

        Calcula calc = new Calcula();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "3";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "0";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "";

            lblDisplay.Text = lblDisplay.Text + "9";
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "+";

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            Double v2 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = calc.calcular(v1, v2, op) + "";
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "-";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "*";
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "/";
        }

        private void BtnSeno_Click(object sender, EventArgs e)
        {
            double v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = calc.seno(v1)+ "";
        }

        private void BtnCoseno_Click(object sender, EventArgs e)
        {
            double v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = calc.cosseno(v1) + "";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            v1 = 0.0;
            op = "";
            lblDisplay.Text = "0";
        }

        private void BtnBackspace_Click(object sender, EventArgs e) //metodo que apaga o ultimo caractere da string
        {
            if (!String.IsNullOrEmpty(lblDisplay.Text))
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }
        }

        private void BtnPonto_Click(object sender, EventArgs e) //adiciona uma virgula para formar um número decimal
        {
            if (!lblDisplay.Text.Contains(","))
            {
                lblDisplay.Text = lblDisplay.Text + ",";
            }
        }

        private void BtnInverter_Click(object sender, EventArgs e) //transforma o numero em negativo ou positivo
        {
            Double v1 = Double.Parse(lblDisplay.Text);
            v1 = v1 * -1;
            lblDisplay.Text = v1.ToString();
        }

        private void rdoBin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBin.Checked && !converte)
            {
                try
                {
                    converte = true;
                    int dec = int.Parse(lblDisplay.Text);
                    lblDisplay.Text = calc.decbin(dec);

                } catch(Exception)
                {
                    MessageBox.Show("Erro ao converter binário");
                }
                finally
                {
                    converte = false;
                }
            }
        }

        private void rdoDec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDec.Checked && !converte)
            {
                try
                {
                    converte = true;
                    string bin = lblDisplay.Text;
                    lblDisplay.Text = calc.bindec(bin);
                } catch(Exception)
                {
                    MessageBox.Show("Erro ao converter decimal");
                }
                finally
                {

                converte = false; 

                }
            }
        }
    }
}
