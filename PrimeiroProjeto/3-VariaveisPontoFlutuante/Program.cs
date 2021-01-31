using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_VariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variáveis com ponto flutuante.");

            double salario;
            salario = 1350.50;
            Console.WriteLine(salario);

            salario = 1500;
            Console.WriteLine("Seu salário é: " + salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade);
            idade = 15.0 / 2;
            Console.WriteLine(idade);


            Console.WriteLine("Fim da aplicação. Tecle enter para continuar.");
            Console.ReadLine();
        }
    }
}
