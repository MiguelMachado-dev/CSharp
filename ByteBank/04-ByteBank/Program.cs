using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Miguel";

            Console.WriteLine($"Saldo atual: {conta.saldo}");
            conta.Sacar(50);
            Console.WriteLine($"Saldo apos saque: {conta.saldo}");

            conta.Depositar(500);
            Console.WriteLine($"Saldo apos deposito: {conta.saldo}");

            Console.ReadLine();
        }
    }
}
