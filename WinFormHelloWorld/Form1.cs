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
    public partial class FormHelloWorld : Form
    {
        public FormHelloWorld()
        {
            InitializeComponent();
        }

        private void btnSaudacao_Click(object sender, EventArgs e)
        {
            //Declaração de variáveis + Entrada de dados
            string nome = tbxSaudacao.Text;

            //Processamento

            //Saida de dados
            MessageBox.Show($"Seu nome é {nome}.", "Olá mundo!");

            lblSaudacaoSaida.Text = nome;

        }
    }
}
