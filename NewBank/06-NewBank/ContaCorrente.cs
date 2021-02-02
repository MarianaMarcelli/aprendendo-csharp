//using _05_NewBank;

namespace _06_NewBank
{
    public class ContaCorrente
    {
        
        public Cliente Titular { get; set; }
        public int Conta { get; set; }
        public int Agencia { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        ////Definir saldo()
        //public void SetSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }

        //    this.saldo = saldo;
        //}

        ////ObterSaldo()
        //public double GetSaldo()
        //{
        //    return saldo;
        //}
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }


       
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}