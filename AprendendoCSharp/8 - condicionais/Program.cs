using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando projeto 8...");

            int idadeMiguel = 22;
            bool acompanhado = true;

            if (idadeMiguel >= 18 && acompanhado)
            {
                Console.WriteLine("Tudo certo, pode entrar!");
            }
            else
            {
                Console.WriteLine("Algo impossibila a entrada.");
            }

            Console.ReadLine();
        }
    }
}
