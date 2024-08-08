using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionSix {
    internal class Alturas {
        static void Main(string[] args) {

            Console.WriteLine("Quantas pessoas vc vai fazer a medição da altura? ");
            int n = int.Parse(Console.ReadLine());

            double[] heights = new double[n];

            for (int i = 0; i < n; i++) {
                heights[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += heights[i];
            }

            Console.WriteLine($"Altura média = {(sum / n).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
