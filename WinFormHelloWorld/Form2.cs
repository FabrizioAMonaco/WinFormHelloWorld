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
    public partial class FormSoma : Form
    {
        public FormSoma()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis
            double num1 = Convert.ToDouble(tbxNum1.Text);
            double num2 = Convert.ToDouble(tbxNum2.Text);
            double num3 = Convert.ToDouble(tbxNum3.Text);
            double num4 = Convert.ToDouble(tbxNum4.Text);

            //Processamento
            double Soma = num1 + num2 + num3 + num4;

            //Resultado
            lblResultado.Text = Soma.ToString();
            lblNomeResultado.Text = "Soma:";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            tbxNum1.Text = "";
            tbxNum2.Text = "";
            tbxNum3.Text = "";
            tbxNum4.Text = "";
            lblResultado.Text = "";
            lblNomeResultado.Text = "";

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //Declaração de Variáveis
            double num1 = Convert.ToDouble(tbxNum1.Text);
            double num2 = Convert.ToDouble(tbxNum2.Text);
            double num3 = Convert.ToDouble(tbxNum3.Text);
            double num4 = Convert.ToDouble(tbxNum4.Text);

            //Processamento
            double Media = (num1 + num2 + num3 + num4)/4;

            //Resultado
            lblResultado.Text = Media.ToString();
            lblNomeResultado.Text = "Média:";
        }
    }
}
