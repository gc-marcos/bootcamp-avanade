using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O saldo é: " + saldo);
        }
    }
}