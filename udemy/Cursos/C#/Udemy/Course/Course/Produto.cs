using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {

        }

        public override string ToString() {
            return $"Dados do produto: {Nome}, {Preco:C2}, {Quantidade} unidades, Total: {Quantidade * Preco:C2}";
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
            ToString();
        }

        public void AdicionarProduto( int num ) {
            Quantidade += num;
        }

        public void RemoverrProduto(int num) {
            Quantidade -= num;
        }

        /*
         Produto p = new Produto();

            Console.WriteLine("Vamos cadastrar um novo produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor em estoque: " + p.ValorTotalEmEstoque());

            Console.WriteLine(p.ToString());

            Console.Write("Quantidade de items para adicioanr: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine(p.ToString());

            Console.Write("Quantidade de items para remover: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverrProduto(qtd);
            Console.WriteLine(p.ToString());
         */
    }
}
