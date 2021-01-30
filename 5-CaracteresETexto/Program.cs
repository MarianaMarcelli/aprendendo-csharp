using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5- caracteres e texto");
            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Aprendendo char e textos em C#" + 2021;
            string pulandoLinhasNaString =
@"primeira linha;
segunda linha,
terceira linha.";

            Console.WriteLine(pulandoLinhasNaString);

            Console.WriteLine("Fim da execução. Tecle enter.");
            Console.ReadLine();

        }
    }
}
