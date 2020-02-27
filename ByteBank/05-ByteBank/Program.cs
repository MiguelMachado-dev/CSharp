using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente miguel = new Cliente();

            miguel.nome = "Miguel Machado";
            miguel.profissao = "FullStack Developer";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = miguel;
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
