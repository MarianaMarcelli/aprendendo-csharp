using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                    Console.WriteLine(numero);
            }

            Console.WriteLine();

            for(int i = 3; i < 100; i+=3)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
