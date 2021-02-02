using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //como agopra possuimos um construtor é necessário atribuir os valores para agência e conta criar a nova conta.
            ContaCorrente conta = new ContaCorrente(865, 865001);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Conta);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaDois = new ContaCorrente(865, 865002);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();

        }
    }
}
