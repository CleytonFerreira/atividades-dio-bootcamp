using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void creditar(double valor);

        public void exibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é {saldo}");
        }
    }
}