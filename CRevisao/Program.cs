using System.Net.Http.Headers;

namespace CRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que calcule a média do aluno

            double nota1, nota2, media;
            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1+nota2)/2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media > 5)
            {
                Console.WriteLine("Recuperação.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
            
        }
    }
}
