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
    public partial class ListForm : Form
    {
        public int Repeticao = 0;

        public ListForm()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lbxList.Items.Clear();
            Repeticao++;

            // Le dados
            int Num = Convert.ToInt32(tbxNum.Text);
            int Soma = 0;


            // For
            for (int i = 1; i <= Num; i++)
            {
                lbxList.Items.Add(i);
                Soma += i;
            }

            lbxList.Items.Add($"A Soma é: {Soma}");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Função Progressão Aritimetica (PA)

            lbxList.Items.Clear();

            // Le dados
            int a1 = Convert.ToInt32(tbxNum.Text);
            int r = Convert.ToInt32(tbxRazao.Text);
            int n = Convert.ToInt32(tbxQtdTermos.Text);
            int an = 0;


            // For
            for (int i = 1; i <= n; i++)
            {
                an = a1 + (i - 1) * r;
                lbxList.Items.Add($"a{i} = {an}");
                
            }

        }

        private void btnPG_Click(object sender, EventArgs e)
        {
            // Função Progressão Aritimetica (PG)

            lbxList.Items.Clear();

            // Le dados
            double a1 = Convert.ToDouble(tbxNum.Text);
            double q = Convert.ToDouble(tbxRazao.Text);
            double n = Convert.ToDouble(tbxQtdTermos.Text);
            double exp;
            double an = 0;


            // For
            for (double i = 1; i <= n; i++)
            {
                exp = (i - 1);
                an = a1 * Math.Pow(q, exp);
                lbxList.Items.Add($"a{i} = {an}");

            }
        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            // Função Fibonacci

            lbxList.Items.Clear();

            // Le dados e declara variáveis
            double n = Convert.ToDouble(tbxNum.Text);
            double fn1 = 0;
            double fn2 = 0;
            double fibo = 0;

            // For
            for (double i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    fibo = 0;
                    lbxList.Items.Add($"{fibo}");
                }
                else if (i == 2)
                {
                    fn1 = 0;
                    fn2 = 1;
                    fibo = 1;
                    lbxList.Items.Add($"{fibo}");
                }
                else
                {
                    // Calcula Fibo
                    fibo = fn1 + fn2;
                    lbxList.Items.Add($"{fn1} + {fn2} = {fibo}");

                    // Atualiza termos da fibo
                    fn1 = fn2;
                    fn2 = fibo;
                }

            }
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            // Função Primo

            lbxList.Items.Clear();

            // Le dados e declara variáveis
            double n = Convert.ToDouble(tbxNum.Text);
            double resto = 0;
            double i = 2;       // Contador para os divisores
            double j = 2;       // Contador até o número 'n'

            // Faz o looping para cada número até 'n'
            for (j = 2; j <= n; j++)
            {
                // Testa os divisores de 'n' até Resto = 0
                i = 2;
                do
                {
                    resto = (j % i);
                    i++;

                } while (resto > 0);
                if (j == (i - 1))
                {
                    lbxList.Items.Add(j);
                }
            }

        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            // Função Fatorial
            lbxList.Items.Clear();

            // Le dados e Declara variáveis
            double n = Convert.ToDouble(tbxNum.Text);
            double fatorial = 1;

            // Processamento
            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
                lbxList.Items.Add($"{i}! = {fatorial}");
            }

        }
    }
}
