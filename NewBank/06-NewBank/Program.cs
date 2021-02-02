using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente
            {
                Nome = "Júlia",
                CPF = "111.111.111-60",
                Profissao = "Desenvolvedora"
            };

            //não irá alterar o valor, pois o campo(propriedade) saldo agora é privado
            conta.Saldo =-10;
            conta.Titular = cliente;
           


            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
