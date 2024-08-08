using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionFive {
    internal class Conta {

        public string Name { get; set; }
        public string NumeroConta { get; private set; }
        public double Saldo { get; set; }

        public Conta() {
        }

        public Conta(string name, string numeroConta, double saldo) {
            Name = name;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public Conta(string name, string numeroConta) {
            Name = name;
            NumeroConta = numeroConta;
            Saldo = 0;
        }

        public override string ToString() {
            return $"Conta {NumeroConta}, Titular: {Name}, Saldo: {Saldo:C2}";
        }

        public double RealizarDeposito(double saldo) {
            return Saldo += saldo;
        }

        public double RealizarSaque(double saldo) {
            return Saldo -= (saldo + 5);
        }
    }
}
