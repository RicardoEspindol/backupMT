using System;
using System.Collections.Generic;

namespace SectionSeven
{
    internal class Program
    {
        static void Main(string[] args) { 
                
            List<string> nomes = new List<string>();

            nomes.Add("Ana");
            nomes.Add("Maria");
            nomes.Add("Julia");
            nomes.Add("Marisa");
            nomes.Add("Paula");
            nomes.Insert(2,"Melissa");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista = " +  nomes.Count);

            Console.WriteLine("------------ ------------- ------------");


            string valid1 = nomes.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro acontecimento = " + valid1);

            string valid2= nomes.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último acontecimento = " + valid2);

            int pos1 = nomes.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do ultimo acontecimento = " + pos1);
            
            int pos2= nomes.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do ultimo acontecimento = " + pos2);

            Console.WriteLine("------------ ------------- ------------");
            List<string> list = nomes.FindAll(x => x.Length > 5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------ ------------- ------------");

            nomes.Remove("Ana");
            nomes.RemoveAt(3);
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}