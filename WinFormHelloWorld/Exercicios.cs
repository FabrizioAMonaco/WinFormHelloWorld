using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Adicionando a biblioteca
using ClassLibraryCalculadora;

namespace WinFormHelloWorld
{
    public partial class Exercicios : Form
    {

        //Declaração de Variáveis Globais para Calculadora
        public string Operador;
        public string Num1;
        public string Num2;
        public double ResultCalc;

        //Criação do Objeto Calculadora
        private ClassCalculator _calculadora = new ClassCalculator(0, 0);

        public Exercicios()
        {
            InitializeComponent();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            //Verifica se não tem mensagem de erro no display
            if (tbxCalcDisplay.Text != "!err!" && tbxCalcDisplay.Text != "")
            {
                Operador = "+";
                Num1 = tbxCalcDisplay.Text;
                lblHistorico.Text = Num1 + " " + Operador + " ";
                tbxCalcDisplay.Text = "";
            } else
            {
                btnLimpa_Click(sender, e);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Num1 = tbxCalcDisplay.Text;
            lblHistorico.Text = Num1 + " " + Operador + " ";
            tbxCalcDisplay.Text = "";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Num1 = tbxCalcDisplay.Text;
            lblHistorico.Text = Num1 + " " + Operador + " ";
            tbxCalcDisplay.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Num1 = tbxCalcDisplay.Text;
            lblHistorico.Text = Num1 + " " + Operador + " ";
            tbxCalcDisplay.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            
            // Precisa tratar quando o display estiver mostrando erro ou estiver vazio ""!!!
            if (tbxCalcDisplay.Text != "") 
            Num2 = tbxCalcDisplay.Text;
            lblHistorico.Text = lblHistorico.Text + Num2 + " = ";

            // Código Refatorado
            if (Num1 == "")
            {
                //Se não tiver Num1, carrega Num2 no display
                tbxCalcDisplay.Text = Num2;
            } else if ((Operador != "/") && (Convert.ToDouble(Num2) != 0))
            {
                ResultCalc = _calculadora.Calcular(Convert.ToDouble(Num1), Convert.ToDouble(Num2), Operador);
                tbxCalcDisplay.Text = Convert.ToString(Math.Round(ResultCalc, 2));
            } else
            {
                //Erro de Divisão por 0
                tbxCalcDisplay.Text = "!err!";
            }

            // Processamento Antigo
            //if (Operador == "+")
            //{
            //    //ResultCalc = Convert.ToDouble(Num1) + Convert.ToDouble(Num2);
            //    ResultCalc = _calculadora.Somar(Convert.ToDouble(Num1), Convert.ToDouble(Num2));
            //    // Resultado
            //    tbxCalcDisplay.Text = Convert.ToString(Math.Round(ResultCalc,2));

            //} else if (Operador == "-")
            //{
            //    //ResultCalc = Convert.ToDouble(Num1) - Convert.ToDouble(Num2);
            //    ResultCalc = _calculadora.Subtrair(Convert.ToDouble(Num1), Convert.ToDouble(Num2));
            //    // Resultado
            //    tbxCalcDisplay.Text = Convert.ToString(Math.Round(ResultCalc, 2));

            //} else if (Operador == "*")
            //{
            //    //ResultCalc = Convert.ToDouble(Num1) * Convert.ToDouble(Num2);
            //    ResultCalc = _calculadora.Multiplicar(Convert.ToDouble(Num1), Convert.ToDouble(Num2));
            //    // Resultado
            //    tbxCalcDisplay.Text = Convert.ToString(Math.Round(ResultCalc, 2));

            //} else if ((Operador == "/") && (Convert.ToDouble(Num2) != 0))
            //{
            //    //ResultCalc = Convert.ToDouble(Num1) / Convert.ToDouble(Num2);
            //    ResultCalc = _calculadora.Dividir(Convert.ToDouble(Num1), Convert.ToDouble(Num2));
            //    // Resultado
            //    tbxCalcDisplay.Text = Convert.ToString(Math.Round(ResultCalc, 2));
            //} else
            //{
            //    // Resultado para divisão por 0
            //    tbxCalcDisplay.Text = "!err!";
            //}
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbxCalcDisplay.Text == "")
            {
                tbxCalcDisplay.Text += "0";
            } else if (Convert.ToDouble(tbxCalcDisplay.Text) > 0)
            {
                tbxCalcDisplay.Text += "0";
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text = "";
            lblHistorico.Text = "";
            Operador = "";
            Num1 = "";
            Num2 = "";
            ResultCalc = 0;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (tbxCalcDisplay.Text.Length > 0)
            {
                tbxCalcDisplay.Text += ",";
            
            } else
            { 
                tbxCalcDisplay.Text = "0,";
            }
            
        }

        private void tbxCalcDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            // Outros caracteres permitidos:
            // , => 2C | '*' => 2A | '+' => 2B | '-' => 2D | '/' => 2F | '=' => 3D
            // 'Enter' => 0D
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
