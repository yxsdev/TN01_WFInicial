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
            int num2 = int.Parse(txtValorHora.Text);
            int num3 = int.Parse(txtQuantHora.Text);

            double resultado = num2 * num3;

            MessageBox.Show($"O salário de {nome} é de R${resultado:F2}");
        }
    }
}
