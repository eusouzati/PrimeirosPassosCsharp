using System;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuntando o projeto 5 - caracteres e textos");

            char primeiraLetra = 'M';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)68;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            string titulo1 = @"- Alura
- Cursos
- Tecnologia";
            Console.WriteLine(titulo1);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
