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

            double resultado_Parcial = Math.Sqrt(Math.Pow(B, 2) - (4*A*C));

            double X = (-B + resultado_Parcial) / (2*A);

           Console.WriteLine("El resultado es: " + X);

            Console.ReadKey();
        }
    }
}
