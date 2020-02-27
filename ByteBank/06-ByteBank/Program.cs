using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Miguel Machado";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;

            conta.Saldo = 20;
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine($"Saldo da conta: {conta.Saldo}");

            Console.ReadLine();
        }
    }
}
