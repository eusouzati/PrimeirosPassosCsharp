using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calculando poupança 2!");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 360; contadorMes++)
            {
                // valorInvestido = valorInvestido + valorInvestido * 0.0036;
                // valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                

                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
            }         

            Console.ReadLine();
        }
    }
}
