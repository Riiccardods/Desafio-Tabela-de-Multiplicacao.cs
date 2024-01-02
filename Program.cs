using System;

namespace TabelaMultiplicacao
{

    class Program
    {
        static void Main(string[] args)
        {

            #region Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($" {n} x {i} = {n * i}");
                } 
            }

            else
            {
                Console.WriteLine("error");
            }
            #endregion

            Console.ReadLine();

            Console.WriteLine($"Ola {n}");
        }
    }
}
