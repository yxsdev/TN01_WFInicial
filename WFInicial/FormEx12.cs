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
    public partial class FormEx12 : Form
    {
        public FormEx12()
        {
            InitializeComponent();
        }
        public int[] numeros = new int[20];
        public int[] pares = new int[0];
        public int[] impares = new int[0];
        public int contagem = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            numeros[contagem] = numero;

            if (contagem < 20)
            {
                if (numero % 2 == 0)
                {
                    Array.Resize(ref pares, pares.Length + 1);
                    pares[pares.Length - 1] = numero;
                }
                else
                {
                    Array.Resize(ref impares, impares.Length + 1);
                    impares[impares.Length - 1] = numero;
                }
            }

            if (contagem == 20)
            {
                for(int i = 0; i < numeros.Length; i++)
                {
                    lblNumeros.Text += numeros[i] + ",";
                }
                for (int i = 0; i < pares.Length; i++)
                {
                    lblPar.Text += pares[i] + ",";
                }
                for (int i = 0; i < impares.Length; i++)
                {
                    lblImpar.Text += impares[i] + ",";
                }
            }

            contagem++;
            lblContador.Text = contagem.ToString();
            txtNumero.Text = "";

        }
    }
}
