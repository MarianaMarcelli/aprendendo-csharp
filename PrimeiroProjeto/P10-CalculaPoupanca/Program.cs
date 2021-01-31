using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - While");

            double valorInvestido = 1000;
            int contador = 1;

            //0,36% = 0.0036

            while (contador <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após " + contador + " meses você terá R$" + valorInvestido);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
