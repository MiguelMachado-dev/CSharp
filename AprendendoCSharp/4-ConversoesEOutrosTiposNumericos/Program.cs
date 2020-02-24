using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Projeto 4");

            double salario = 1200.50;

            // O int é um tipo de variável que suporta valores até 32 bits
            int salarioInt = (int)salario;

            Console.WriteLine(salario); // Writes 1200.5
            Console.WriteLine(salarioInt); // Writes 1200

            // Para numeros muito grandes
            // O long é uma variável de 64 bits
            long idadeDoPlaneta = 13000000000;
            Console.WriteLine($"idade do planeta: {idadeDoPlaneta}");

            // Para numeros pequenos
            // O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 16000;
            Console.WriteLine($"Quantidade de produtos a ser comprados: {quantidadeProdutos}");

            // float tem precisao menor que o double, pouco usual
            float altura = 1.70f; // Adiciona o sufixo f
            Console.WriteLine($"Altura do user: {altura}");


            Console.WriteLine("Finalizando projeto. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}
