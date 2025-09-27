using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pootrainig.Models;

namespace Pootrainig.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome) : base(nome)
        {
        
        }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o diretor {Nome}, tenho {Idade} anos, e " + $"recebo {Salario} reais de salário");
        }
    }
}