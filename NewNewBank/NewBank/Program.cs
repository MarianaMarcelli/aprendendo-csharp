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

            Funcionario mari = new Funcionario(2000, "111.111.111-01")
            {
                Nome = "Mari",
            };

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            mari.AumentarSalario();
            Console.WriteLine("Novo salário de Mari: " + mari.Salario);

            Diretor diretor = new Diretor("111.222.111-02")
            {
                Nome = "Diretor",
            };

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario diretorTeste = diretor;

            diretor.AumentarSalario();
            Console.WriteLine("Novo salário de diretor: " + diretor.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + diretor.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + diretorTeste.GetBonificacao());

            gerenciador.Registrar(mari);
            gerenciador.Registrar(diretor);


            Console.WriteLine(mari.GetBonificacao());
            Console.WriteLine(diretor.GetBonificacao());
            Console.WriteLine("Total de bonificação: R$" + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
