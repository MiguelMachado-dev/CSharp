using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando projeto 5...");

            char primeiraLetra = 'M'; // Usa-se aspas simples
            Console.WriteLine($"\nA primeira letra do meu nome eh: {primeiraLetra}\n");

            string primeiroTexto = "Hello, World!";
            Console.WriteLine(primeiroTexto);

            Console.WriteLine("A execucao terminou, tecle Enter para finalizar...");
            Console.ReadLine();
        }
    }
}
