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
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtNome.Text);
            double num2 = Double.Parse(txtValorHora.Text);
            int num3 = int.Parse(txtQuantHora.Text);

            double resultado = num2 * num3;

            string mensagem = $"O salário de {nome} é de R${resultado:F2}");

            MessageBox.Show(mensagem, "Info", 
                MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
