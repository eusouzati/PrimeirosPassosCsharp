using System;

namespace _4_ConvensoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // O int é um tipo de variável de até 32 bits, o long é de 64 bits e short de 16 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
                       
            Console.WriteLine("Salario em inteiro é: " + salarioEmInteiro);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
