namespace WFInicial
{
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show(
                    "Aprovado!", 
                    "Ok",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else if (media > 5)
            {
                MessageBox.Show(
                    "Recuperação!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Reprovado!",
                    "Deu ruim!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
