using System;

namespace TabelaMultiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número para ver sua tabela de multiplicação: ");
            if(int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($" {n} x {i} = {n * i}");
                } 
            }

            else
            {
                Console.WriteLine("error");
            }

            Console.ReadLine();
        }
    }
}
