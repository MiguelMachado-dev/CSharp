using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3...");

            double salario;
            int multiplicador;
            salario = 1200.70;
            multiplicador = 4;

            Console.WriteLine("Valor do salario: " + salario * multiplicador);
            Console.WriteLine();

            Console.WriteLine("A execucao terminou, tecle Enter para finalizar. . .");
            Console.ReadLine();
        }
    }
}
