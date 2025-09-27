using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pootrainig.Models
{
    public class Professor : Pessoa
    {
        public Professor (string nome) : base(nome)
        {

        }
        public decimal Salario {get;set;}

          public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor {Nome}, tenho {Idade} anos, e " + $"recebo {Salario} reais de salário");
        }
    }
}