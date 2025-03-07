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
    public partial class FormEx8 : Form
    {
        public FormEx8()
        {
            InitializeComponent();
        }

        private void FormEx8_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, num1, num2 = 0;
            bool ehValidoNum1 = double.TryParse( txtNum1.Text , out num1);
            bool ehValidoNum2 = double.TryParse( txtNum2.Text , out num2);

            if (!ehValidoNum1 || !ehValidoNum2) //Valida se o valor digitado é um número
            {
                MessageBox.Show("Os valores digitados não são um número.", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdbSoma.Checked)
            {
                resultado = num1 + num2;
                string mensagem = $"A soma de {num1} + {num2} é igual á {resultado}.";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbSubtracao.Checked)
            {
                resultado = num1 - num2;
                string mensagem = $"A subtração de {num1} - {num2} é igual á {resultado}.";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbMutiplicacao.Checked)
            {
                resultado = num1 * num2;
                string mensagem = $"A multiplicação de {num1} x {num2} é igual á {resultado}.";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbDivisao.Checked)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("O denominador não pode ser zero.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resultado = num1 / num2;
                    string mensagem = $"A divisão de {num1} / {num2} é igual á {resultado}.";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdbPotenciacao.Checked)
            {
                resultado = Math.Pow(num1, num2);
                string mensagem = $"A Potenciação de {num1} ^ {num2} é igual á {resultado}.";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbRadiciacao.Checked)
            {
                if (num2 == 0)
                    resultado = 1;
                else
                    resultado = Math.Pow(num1, (1 / num2));

                    string mensagem = $"A raiz de {num1} ^ {num2} é igual á {resultado}.";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você deve escolher uma operação!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
