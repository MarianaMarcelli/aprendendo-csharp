﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8");

            int idadeJoao = 16;
            //int quantidadeDePessoas = 2;
            //bool acompanhado = quantidadeDePessoas >= 2;
            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entar");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");

            }
            Console.ReadLine();
        }
    }
}
