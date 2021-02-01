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
            // Cliente julia = new Cliente();

            // julia.nome = "Júlia";
            // julia.cpf = "111.000.111-01";
            // julia.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente
            {
                //pode ser feita a inicialização na própria classe (verificar em ContaCorrente)
                titular = new Cliente
                {
                    nome = "Júlia",
                    cpf = "111.000.111-01",
                    profissao = "Desenvolvedora C#"
                },
                saldo = 500,
                agencia = 865,
                conta = 865111
            };

            //Console.WriteLine(julia.nome);
            Console.WriteLine(conta.titular.nome);

            conta.titular.nome = "Júlia Juba";
           //Console.WriteLine(julia.nome);
            Console.WriteLine(conta.titular.nome);


            Console.ReadLine();
        }
    }
}
