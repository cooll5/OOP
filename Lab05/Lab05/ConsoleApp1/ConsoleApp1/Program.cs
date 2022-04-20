using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var fr1 = Fraction.ToFraction(10);
            var fr2 = Fraction.ToFraction(5.5);

            Console.WriteLine($" First number = {fr1}");
            Console.WriteLine($" Second number = {fr2}");
            Console.WriteLine();
            Console.WriteLine($"Task 1 (+) = {fr1 + fr2}");
            Console.WriteLine($"Task 2 (-) = {fr1 - fr2}");
            Console.WriteLine($"Task 3 (*) = {fr1 * fr2}");
            Console.WriteLine($"Task 4 (/) = {fr1 / fr2}");
            Console.ReadLine();
        }

    }
}

