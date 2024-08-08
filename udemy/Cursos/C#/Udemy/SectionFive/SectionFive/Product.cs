using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionFive {
    internal class Product {

        /*
            Auto Properties
         */
        private string _nome;
        private double Preco { get; set; }
        private int Quantidade { get; set; }

        public Product() {
        }
        public Product(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /*
            Por causa da verificação de entrada o _nome não pode ter auto propertie 
         */
        public string Nome { 
            get { return _nome; }
            set {
                if (value != _nome && value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        
        /* - Properties

        public double Preco {
            get { return _preco; }
            set {
                if (value != _preco && value > 0) {
                    _preco = value;
                }
            }
        }
        
        public int Quantidade{
            get { return _quantidade; } 
            set {
                if (value != _quantidade && value > 0) {
                    _quantidade = value;
                }
            }
        }
        */

        public override string ToString() {
            return $"Dados do produto: {_nome}, {Preco:C2}, {Quantidade} unidades, Total: {Quantidade * Preco:C2}";
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int num) {
            Quantidade += num;
        }

        public void RemoverrProduto(int num) {
            Quantidade -= num;
        }

        /*
         
            Console.WriteLine("Vamos cadastrar um novo produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Product p = new Product(nome, preco , quantidade);
   
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

            Product p2 = new Product("Celular", 12 , 40);

            Console.WriteLine(p2.ToString());
         */
    }

}

