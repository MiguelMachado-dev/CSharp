public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    // Retorna valor = function
    public bool Sacar(double valor) // Esta funcao retorna um boolean
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    // Nao retorna = metodo
    public void Depositar(double valor) // void -> function nao tem retorno, nao devolve nada
    {
        this.saldo += valor;
    }
}