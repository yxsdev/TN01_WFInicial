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
    public partial class FormEx9 : Form
    {
        public FormEx9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            bool entrou = true;
            user.Nome = txtUsuario.Text;
            user.Senha = txtSenha.Text;

            entrou = user.efetuarlogin();
            if (entrou == false)
            {
                txtSenha.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                MessageBox.Show("Login efetuado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose(); //fecha a janela
            }
        }
    }
}
