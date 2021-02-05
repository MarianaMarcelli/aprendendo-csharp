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
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario julia = new Designer("111.222.333-33");
            julia.Nome = "Júlia";

            Funcionario lucas = new Diretor("111.112.113-04");
            lucas.Nome = "Lucas";

            Funcionario babi = new Auxiliar("121.131.141-41");
            babi.Nome = "Babi";

            Funcionario luiza = new GerenteDeConta("222.333.555-66");
            luiza.Nome = "Luiza";

            Desenvolvedor mari = new Desenvolvedor("332.111.118-01");
            mari.Nome = "Mari";

            gerenciadorBonificacao.Registrar(mari);
            gerenciadorBonificacao.Registrar(julia);
            gerenciadorBonificacao.Registrar(luiza);
            gerenciadorBonificacao.Registrar(lucas);
            gerenciadorBonificacao.Registrar(babi);

            Console.WriteLine("O total mensal de de bonificações é de R$ " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}





//Para verificar diferenças conforme estudo vai avançando

//        static void Main(string[] args)
//        {
//            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

//            //não compila mais pois a classe funcionário passou a ser abstrata.
//            //Funcionario mari = new Funcionario(2000, "121.111.123-12");

//            Funcionario mari = new Designer("121.111.123 - 12");
//            Console.WriteLine(Funcionario.TotalDeFuncionarios);
//            mari.AumentarSalario();
//            Console.WriteLine("Novo salário de Mari: " + mari.Salario);

//            Diretor diretor = new Diretor("111.222.111-02")
//            {
//                Nome = "Diretor",
//            };

//            Console.WriteLine(Funcionario.TotalDeFuncionarios);

//            Funcionario diretorTeste = diretor;

//            diretor.AumentarSalario();
//            Console.WriteLine("Novo salário de diretor: " + diretor.Salario);

//            Console.WriteLine(Funcionario.TotalDeFuncionarios);

//            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + diretor.GetBonificacao());
//            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + diretorTeste.GetBonificacao());

//            gerenciador.Registrar(mari);
//            gerenciador.Registrar(diretor);


//            Console.WriteLine(mari.GetBonificacao());
//            Console.WriteLine(diretor.GetBonificacao());
//            Console.WriteLine("Total de bonificação: R$" + gerenciador.GetTotalBonificacao());

//            Console.ReadLine();
//        }
//    }
//}
