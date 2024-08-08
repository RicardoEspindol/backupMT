using System;
using System.Globalization;

namespace SectionFive {
    internal class Program {
        static void Main(string[] args) {
            Conta conta1;

            Console.WriteLine("Vamos cadastar sua conta. Vique atento aos seus dados. \n => Cuida que é meio dia!");
            Console.Write("Entre o numero da conta: ");
            string conta = Console.ReadLine();

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string cond = Console.ReadLine();

            if (cond == "s") {
                Console.Write("\nEntre com o valor do depósito inicial: ");
                double valor = int.Parse(Console.ReadLine());
                conta1 = new Conta(nome, conta, valor);
            } else {
                conta1 = new Conta(nome, conta);
            }

            Console.Write("\nEntre com um valor para despósito: ");
            int deposito = int.Parse(Console.ReadLine());
            conta1.RealizarDeposito(deposito);
            Console.WriteLine($"Dados da Conta atualizados: \n => {conta1}");

            Console.Write("\nEntre com um valor para saque: ");
            int saque = int.Parse(Console.ReadLine());
            conta1.RealizarSaque(saque);
            Console.WriteLine($"Dados da Conta atualizados: \n => {conta1}");
        }
    }
}