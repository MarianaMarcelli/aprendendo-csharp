using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");
            int idade = 32;
            int segundaIdade = idade;

            //imprime 32 nas duas variáveis
            Console.WriteLine(idade);
            Console.WriteLine(segundaIdade);

            //imprime 20 em idade e 32 em segundaIdade, variáveis guardam valores e não referências.
            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(segundaIdade);

            Console.ReadLine();

        }
    }
}
