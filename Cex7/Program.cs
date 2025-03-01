using System.Drawing;
using System.Text;

namespace Cex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um formulário que o usuário escreva o nome e o preço de seis 
            //produtos e assim que terminar de escrever o ultimo produto, mostre o
            //nome e o valor do produto mais barato.

            string[] nomes = new string [6];
            double[] precos = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                nomes[i] = Console.ReadLine()!;
                Console.WriteLine("Digite o preço do produto: ");
                precos[i] = double.Parse(Console.ReadLine()!);
            }


        }
    }
}
