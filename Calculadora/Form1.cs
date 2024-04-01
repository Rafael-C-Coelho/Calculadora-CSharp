using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        
        double PrimeiroNumero;
        string Operacao; 
        public Calculadora()
        {
            InitializeComponent();
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            double SegundoNumero;
            double Resultado;

            SegundoNumero = Convert.ToDouble(textBox1.Text);

            if (Operacao == "+")
            {
                Resultado = (PrimeiroNumero + SegundoNumero);
                textBox1.Text = Convert.ToString(Resultado);
                PrimeiroNumero = Resultado;
            }

            if (Operacao == "-")
            {
                Resultado = (PrimeiroNumero - SegundoNumero);
                textBox1.Text = Convert.ToString(Resultado);
                PrimeiroNumero = Resultado;
            }

            if (Operacao == "*")
            {
                Resultado = (PrimeiroNumero * SegundoNumero);
                textBox1.Text = Convert.ToString(Resultado);
                PrimeiroNumero = Resultado;
            }
            if (Operacao == "/")
            {
                if (SegundoNumero == 0)
                {
                    textBox1.Text = "Não pode ser dividido por 0!";
                } else
                {
                    Resultado = (PrimeiroNumero / SegundoNumero);
                    textBox1.Text = Convert.ToString(Resultado);
                    PrimeiroNumero = Resultado;
                }
            }
        }
        private void buttonN1_click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text == null) {
                textBox1.Text = "1";
            } else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == "") 
            {
                textBox1.Text = "2";
            } else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1 == null)
            {
                textBox1.Text = "3";
            }else
            {
                textBox1.Text= textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {

                textBox1.Text = "4";
            }
             else
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "5";
            } else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "0";
            
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operacao = "+";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operacao = "-";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            Operacao = "*";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            Operacao = "/";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
