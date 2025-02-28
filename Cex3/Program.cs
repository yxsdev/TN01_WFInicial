namespace Cex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 3 - Maior número

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\nDigite o segundo: número: ");
            int num2 = Convert.ToInt32(Console.ReadLine()!);

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"\nO maior número é: {maior}"); //Interpolação de string
        }
    }
}
