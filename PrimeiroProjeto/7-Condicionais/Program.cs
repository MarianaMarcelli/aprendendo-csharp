using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;
            int quantidadeDePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos, pode entar");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.Write("João não possui mais de 18 anos, mas está acompanhado, então pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar.");

                }

            }

            Console.ReadLine();
        }
    }
}
