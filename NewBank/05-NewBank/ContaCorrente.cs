//using _05_NewBank;

namespace _05_NewBank
{
    public class ContaCorrente
    {
        //public Cliente titular = new Cliente();
        public Cliente titular;
        public int conta;
        public int agencia;
        public double saldo = 100;

        //quando possui retorno é mais comumente chamada de função
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
        //função sem retorno (void) é mais comumente chamada de método
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        //funções com mais de um argumento
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}