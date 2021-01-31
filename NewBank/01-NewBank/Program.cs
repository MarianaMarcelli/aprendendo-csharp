using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
          ContaCorrente contaDaLuiza = new ContaCorrente();

            contaDaLuiza.titular = "Luiza";
            contaDaLuiza.agencia = 865;
            contaDaLuiza.conta = 865222;
            contaDaLuiza.saldo = 100;

            ContaCorrente contaDaJulia = new ContaCorrente
            {
                titular = "Júlia",
                agencia = 865,
                conta = 865111,
                saldo = 100
            };

            Console.WriteLine(contaDaLuiza.titular);
            Console.WriteLine("Agência: " + contaDaLuiza.agencia);
            Console.WriteLine("Conta: " + contaDaLuiza.conta);
            Console.WriteLine("Saldo: " +  contaDaLuiza.saldo);

            Console.WriteLine();

            contaDaJulia.saldo += 100;

            Console.WriteLine(contaDaJulia.titular);
            Console.WriteLine("Agência: " + contaDaJulia.agencia);
            Console.WriteLine("Conta: " + contaDaJulia.conta);
            Console.WriteLine("Saldo: " + contaDaJulia.saldo);

            Console.ReadLine();
        }
    }
}
