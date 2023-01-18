using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Calculadora_cSharp
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultados.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(resultados.Text, CultureInfo.InvariantCulture);
            resultados.Text = "0";
            operacao = "divisao";
            lbloperacaio.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultados.ClearUndo();
            resultados.Text = "0";
            lbloperacaio.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultados.Text = "0";
        }



        private void button9_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }

            resultados.Text = resultados.Text + "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {


            valor1 = double.Parse(resultados.Text, CultureInfo.InvariantCulture);
            resultados.Text = "0";
            operacao = "multiplicacao";
            lbloperacaio.Text = "X";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(resultados.Text, CultureInfo.InvariantCulture);
            resultados.Text = "0";
            operacao = "soma";
            lbloperacaio.Text = "+";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resultados.Text == "0")
            {
                resultados.Clear();
            }
            resultados.Text = resultados.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(resultados.Text, CultureInfo.InvariantCulture);


            if (operacao == "soma")
            {
                resultados.Text = Convert.ToString(valor1 + valor2);
            }

            else if (operacao == "subtracao")
            {
                resultados.Text = Convert.ToString(valor1 - valor2);
            }

            else if (operacao == "multiplicacao")
            {
                resultados.Text = Convert.ToString(valor1 * valor2);
            }

            else if (operacao == "divisao")
            {
                resultados.Text = Convert.ToString(valor1 / valor2); ;
            }
            else
            {
                resultados.Text = "Insire a operação";
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(resultados.Text, CultureInfo.InvariantCulture);
            resultados.Text = "0";
            operacao = "subtracao";
            lbloperacaio.Text = "-";
        }

        private void lbloperacaio_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button11_Click(object sender, EventArgs e)
        {
            resultados.Text = resultados.Text + ".";

        }


    }
}
