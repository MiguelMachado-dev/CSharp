using System;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        // Propriedades
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0) // value eh o nome do argumento que vem no set
                {
                    return;
                }

                _saldo = value;
            }
        }

        // Retorna valor = function
        public bool Sacar(double valor) // Esta funcao retorna um boolean
        {
            if (_saldo < valor)
            {
                Console.WriteLine("Valor nao permitido para saque");
                return false;
            }

            _saldo -= valor;
            return true;

        }

        // Nao retorna = metodo
        public void Depositar(double valor) // void -> function nao tem retorno, nao devolve nada
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }


            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}
