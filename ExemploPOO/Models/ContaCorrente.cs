using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor);
        
    }
}