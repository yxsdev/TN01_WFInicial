﻿namespace Cex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um formulário que solicite o nome do usuário, o quanto ganha por hora e o número de horas
            //trabalhadas no mês.Calcule o resultado e mostre o nome e o total da renda recebida no mês.

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("\nDigite o quanto você ganha por hora: ");
            double valorHora = double.Parse(Console.ReadLine()!);
            Console.Write("\nDigite o número de horas trabalhadas no mês: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine()!);
            double salario = valorHora * horasTrabalhadas;

            double resultado = valorHora * horasTrabalhadas;

            Console.WriteLine($"\nO salário de {nome} é de R${resultado:F2}");

        }
    }
}
