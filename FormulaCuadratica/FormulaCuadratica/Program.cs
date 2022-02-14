using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaCuadratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo que resulve la ecuacion cuadratica");

            Console.WriteLine("Ingresa A");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa B");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa C");
            int C = int.Parse(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
