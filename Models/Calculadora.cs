using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pootrainig.Models;
using Pootrainig.Interfaces;


namespace Pootrainig.Models
{
    public class Calculadora : ICalculadora
    {
        //o método dividir não foi implementado, pois, na interface ICalculadora, ele tem corpo. Nesse caso
        //sua implementação torna-se opcional
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}