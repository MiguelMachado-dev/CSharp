using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando projeto 10...");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                // 0.36% = 0.36 / 100 = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine($"Apos {contadorMes} mes(es) voce tera R${valorInvestido}");

                contadorMes++; // contadorMes = contadorMes + 1;
            }

            Console.ReadLine();
        }
    }
}
