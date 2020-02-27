using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 568458);
            Console.WriteLine($"Total de contas criadas: {ContaCorrente.TotalDeContasCriadas}\n");

            ContaCorrente contaTeste = new ContaCorrente(867, 568459);
            Console.WriteLine($"Total de contas criadas: {ContaCorrente.TotalDeContasCriadas}\n");

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
