using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx7 : Form
    {
        public string[] ListaNomeProdutos = new string[6];
        public double[] ListaPrecoProdutos = new double[6];
        public int contador = 0;

        public FormEx7()
        {
            InitializeComponent();
        }

        private void lblNome1_Click(object sender, EventArgs e)
        {

        }

        private void FormEx7_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            ListaNomeProdutos[contador - 1] = txtNomeProduto.Text;
            ListaPrecoProdutos[contador - 1] = 
                Convert.ToDouble(txtValorProduto.Text);

            txtNomeProduto.Text = "";
            txtValorProduto.Text = "";

            if (contador == 6)
            {
                double menor = ListaPrecoProdutos.Min();
                int posicao_menor = Array.IndexOf(ListaPrecoProdutos, menor);
                string mensagem = $"O Produto mais barato é {ListaNomeProdutos[posicao_menor]} "
                    + $"de valor R$ {menor:D2}";

                MessageBox.Show(mensagem);
            }

        }
    }
}
