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

            Funcionario carlos = new Funcionario(2000, "186.432.424-64");
            carlos.Nome = "Carlos";
            carlos.AumentarSalario();
            Console.WriteLine($"Novo salário do carlos: {carlos.Salario}");

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("312.321.534-90");
            roberta.Nome = "Roberta";

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
