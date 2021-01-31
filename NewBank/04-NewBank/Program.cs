using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoLucas = new ContaCorrente();

            contaDoLucas.titular = "Lucas";

            Console.WriteLine("Seu saldo é R$ " + contaDoLucas.saldo);

            //guardando o retorno da função
            bool resultadoSaque = contaDoLucas.Sacar(50);

            Console.WriteLine("Seu novo saldo é R$ " + contaDoLucas.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoLucas.Depositar(500);

            Console.WriteLine("Seu novo saldo é R$ " + contaDoLucas.saldo);

            ContaCorrente contaDaJulia = new ContaCorrente
            {
                titular = "Júlia"
            };

           bool resultadoTransferencia = contaDoLucas.Transferir(150, contaDaJulia);

            Console.WriteLine("Saldo do Lucas: R$" + contaDoLucas.saldo);
            Console.WriteLine("Saldo da Júlia: R$" + contaDaJulia.saldo);
            Console.WriteLine("Status transferência: " + resultadoTransferencia);

            Console.ReadLine();

        }
    }
}
