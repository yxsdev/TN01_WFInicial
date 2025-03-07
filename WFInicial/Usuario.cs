using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFInicial
{
    public class Usuario
    {
        public string? Nome { get; set; } //O ? garante qu não será nulo o resultado
        public string? Senha { get; set; }

        public bool efetuarlogin()
        {
            if (Nome == Senha)
            {
                MessageBox.Show("A senha e usuário não podem ser iguais!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
