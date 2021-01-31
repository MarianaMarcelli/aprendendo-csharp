using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NewBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // variável de tipo referência: aponta para o endereço na memória daquela variável
            ContaCorrente contaDaLuiza = new ContaCorrente
            {
                titular = "Luiza",
                agencia = 865,
                conta = 865222,
            };

            ContaCorrente contaDaLuizaLustre = new ContaCorrente
            {
                titular = "Luiza Lustre",
                agencia = 865,
                conta = 865222,
            };

            //false: endereços diferentes, referências diferentes
            // igualdade de tipo de refeência
            Console.WriteLine(contaDaLuiza == contaDaLuizaLustre);

            // variáveis de tipo valor: guardam valores
            int idade = 27;
            int idadeNovamente = 27;

            //true : igualdade de tipo de valor
            Console.WriteLine(idade == idadeNovamente);

            //referenciando o mesmo lugar, referenciando o mesmo objeto na memória
            contaDaLuiza = contaDaLuizaLustre;
            //true
            Console.WriteLine(contaDaLuiza == contaDaLuizaLustre);

            //como as duas variáveis do tipo de referência apontam para o mesmo objeto na memória o valor atribuído será o mesmo
            contaDaLuiza.saldo = 300;
            Console.WriteLine(contaDaLuiza.saldo);
            Console.WriteLine(contaDaLuizaLustre.saldo);

            Console.ReadLine();

        }
    }
}
