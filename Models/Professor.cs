using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario {get;set;}

          public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor {Nome}, tenho {Idade} anos, e " + $"recebo {Salario} reais de salário");
        }
    }
}