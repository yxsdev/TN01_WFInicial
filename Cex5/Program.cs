namespace Cex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\nDigite o segundo: número: ");
            int num2 = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine()!);


            int maior = Math.Max(num1, num2); // Math.Max retorna o maior número entre dois números
            maior = Math.Max(maior, num3);

            int menor = Math.Min(num1, num2); // Math.Min retorna o menor número entre dois números
            menor = Math.Min(menor, num3);

            Console.WriteLine($"\nO maior número é: {maior}");
            Console.WriteLine($"\nO menor número é: {menor}");
        }
    }
}
