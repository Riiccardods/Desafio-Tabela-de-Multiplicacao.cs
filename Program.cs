using System;

namespace TabelaMultiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para ver sua tabela de multiplicação: ");
            int n = int.Parse(Console.ReadLine());


             
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {n} x {i} = {n * i}");
            }

            Console.ReadLine();
        }
    }
}
