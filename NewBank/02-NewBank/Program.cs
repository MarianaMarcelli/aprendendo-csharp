using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Lucas";

            Console.WriteLine(conta.titular);
            //quando não é atribuído nenhum valor à variável ela recebe o valor padrão (default), este também pode ser modificado
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
