using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente julia = new Cliente();

            julia.nome = "Júlia";
            julia.cpf = "111.000.111-01";
            julia.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente
            {
                titular = julia,
                saldo = 500,
                agencia = 865,
                conta = 865111
            };

            Console.WriteLine(julia.nome);
            Console.WriteLine(conta.titular.nome);

            conta.titular.nome = "Júlia Juba";
            Console.WriteLine(julia.nome);
            Console.WriteLine(conta.titular.nome);


            Console.ReadLine();
        }
    }
}
