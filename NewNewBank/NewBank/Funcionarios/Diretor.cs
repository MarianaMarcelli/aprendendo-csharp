﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando diretor");
        }

        public override double GetBonificacao()
        {
            return Salario + (base.GetBonificacao());

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
