using System;

namespace P16_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 16 - Fatorial");

            int fatorial = 1;
            for(int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
