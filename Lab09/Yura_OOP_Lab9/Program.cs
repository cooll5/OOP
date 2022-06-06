using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ellipse:");
            Ellipse a = new Ellipse(5, 7, 5);
            Console.WriteLine($"{a.ToString()}\nFunction: {a.Y()}\n");
            Console.WriteLine("\nHyperbola:");
            Hyperbola b = new Hyperbola(3, 8, 4);
            Console.WriteLine($"{b.ToString()}\nFunction: {b.Y()}");
            Console.ReadKey();
        }
    }
}
