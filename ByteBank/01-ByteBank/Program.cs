using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Miguel";
            conta.agencia = 0001;
            conta.numero = 123456;
            conta.saldo = 100;

            Console.WriteLine(conta.titular);
            Console.WriteLine($"Agencia: {conta.agencia}");
            Console.WriteLine($"Numero da conta: {conta.numero}");
            Console.WriteLine($"Saldo: {conta.saldo}");

            Console.ReadLine();
        }
    }
}
