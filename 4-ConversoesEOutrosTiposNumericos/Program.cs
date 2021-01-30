using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversões e outro tipos numéricos.");

            double salario;
            salario = 1350.75;
            Console.WriteLine(salario);

            //o int é um tipo de variável que suporta 32 bits)
            int salarioInteiro;
            salarioInteiro = (int)salario;
            //casting mudando o tipo da variável
            Console.WriteLine("salário convertido para inteiro: " + salarioInteiro);

            //maior que 2 bilhões(limite 64bits)
            long numerosGrandes = 13000000000;

            //números pequenos(16 bits um pouco maior que 16 mil)
            short quantidadeProdutos;

            //o float não possui uma precisão para casas decimais muito grande.
            //É necessário colocar o f no final para que ele entenda que realmente é um float o desejado.
            float altura = 1.80f;


            Console.WriteLine("Fim da aplicação. Tecle enter para continuar");
            Console.ReadLine();

        }
    }
}
