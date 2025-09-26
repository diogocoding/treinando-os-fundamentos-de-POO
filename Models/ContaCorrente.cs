using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            this.NumeroConta = numeroConta;
            this._saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal _saldo;

        public void Sacar(decimal valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Valor solicitado é superior ao saldo existente em conta");
            }
        }
        public void ExibirSaldo()
        {
            decimal exbrsaldo = _saldo;
            Console.WriteLine($"seu saldo atual é de: {exbrsaldo}");
        }
    }
}