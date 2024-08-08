using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            string[] nomes = new string[] { "Maria", "José", "Jesus" };

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}