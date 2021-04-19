using System;

namespace P14_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 14 - Tabuada!");

            for(int multiplicador = 1; multiplicador <=10; multiplicador++)
            {
                for(int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + "*" + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
