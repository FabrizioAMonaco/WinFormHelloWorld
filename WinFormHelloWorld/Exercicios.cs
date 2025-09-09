using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHelloWorld
{
    public partial class Exercicios : Form
    {

        //Declaração de Variáveis Globais para Calculadora
        public string Operador;
        public string Num1;
        public string Num2;
        public double ResultCalc;

        public Exercicios()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis
            double Idade = Convert.ToDouble(tbxIdade.Text);
            string Resultado;

            //Processamento
            if (Idade >= 65)
            {
                Resultado = "Você é Idoso";
            } else if (Idade >= 18)
            {
                Resultado = "Você é Adulto";
            }
            else if (Idade >= 13)
            {
                Resultado = "Você é adolescente";
            } else if (Idade >= 0)
            {
                Resultado = "Você é criança";
            } else
            {
                Resultado = "A idade precisa ser maior que 0!";
            }
        
            //Resultado
            lblResultado.Text = Resultado;
            tbxIdade.Text = "";
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis e Leitura de dados
            string Entrada = tbxNums.Text;
            string MaiorNum;

            double Num1;
            double Num2;
            double Num3;

            // Processamento
            
            // Separa os números da entrada por ',' ';' e ' '
            string[] Nums = Entrada.Split(',', ' ', ';');
            
            // Converte texto para número
            Num1 = Convert.ToDouble(Nums[0]);
            Num2 = Convert.ToDouble(Nums[1]);
            Num3 = Convert.ToDouble(Nums[2]);
            
            // Encontra o maior número
            if (Num1 > Num2 && Num1 > Num3)
            {
                MaiorNum = "O maior número é: " + Convert.ToString(Num1);

            } else if (Num2 > Num1 && Num2 > Num3)
            {
                MaiorNum = "O maior número é: " + Convert.ToString(Num2);

            } else if (Num3 > Num1 && Num3 > Num2)
            {
                MaiorNum = "O maior número é: " + Convert.ToString(Num3);
            }
            else
            {
                MaiorNum = "Todos os números são iguais!";
            }

            // Resultado
            lblMaiorNum.Text = MaiorNum;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            Operador = "+";
            Num1 = tbxCalcDisplay.Text;
            lblHistorico.Text = Num1 + " " + Operador + " ";
            tbxCalcDisplay.Text = "";
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
            
            Num2 = tbxCalcDisplay.Text;
            lblHistorico.Text = lblHistorico.Text + Num2 + " = ";

            // Processamento
            if (Operador == "+")
            {
                ResultCalc = Convert.ToDouble(Num1) + Convert.ToDouble(Num2);
            
            } else if (Operador == "-")
            {
                ResultCalc = Convert.ToDouble(Num1) - Convert.ToDouble(Num2);
            
            } else if (Operador == "*")
            {
                ResultCalc = Convert.ToDouble(Num1) * Convert.ToDouble(Num2);
            
            } else if (Operador == "/")
            {
                ResultCalc = Convert.ToDouble(Num1) / Convert.ToDouble(Num2);
            }

            // Resultado
            tbxCalcDisplay.Text = Convert.ToString(ResultCalc);
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

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxCalcDisplay.Text += "0";
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
