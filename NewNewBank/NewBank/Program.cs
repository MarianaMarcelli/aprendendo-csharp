using NewBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario mari = new Funcionario
            {
                Nome = "Mari",
                CPF = "111.111.111-01",
                Salario = 2000
            };

            Diretor diretor = new Diretor
            {
                Nome = "Diretor",
                CPF = "111.222.111-02",
                Salario = 5000
            };

            gerenciador.Registrar(mari);
            gerenciador.Registrar(diretor);

            
            Console.WriteLine(mari.GetBonificacao());
            Console.WriteLine(diretor.GetBonificacao());
            Console.WriteLine("Total de bonificação: R$" + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
