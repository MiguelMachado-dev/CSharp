using System;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        // Retorna valor = function
        public bool Sacar(double valor) // Esta funcao retorna um boolean
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Valor nao permitido para saque");
                return false;
            }

            this.saldo -= valor;
            return true;

        }

        // Nao retorna = metodo
        public void Depositar(double valor) // void -> function nao tem retorno, nao devolve nada
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }


            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}
