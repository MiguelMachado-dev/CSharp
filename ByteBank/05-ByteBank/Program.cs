using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cliente miguel = new Cliente();

            //miguel.nome = "Miguel Machado";
            //miguel.profissao = "FullStack Developer";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();
            conta.titular.nome = "Miguel Machado";
            conta.titular.cpf = "123.456.789-01";
            conta.titular.profissao = "FullStack Developer";
            conta.agencia = 0001;
            conta.numero = 1285865;

            //conta.titular = miguel;
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
