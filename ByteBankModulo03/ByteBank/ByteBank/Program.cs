using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("186.432.424-64");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("312.321.534-90");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine($"Total de bonificação: {gerenciador.GetTotalBonificacao()}");
            Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

            Console.ReadLine();
        }
    }
}
