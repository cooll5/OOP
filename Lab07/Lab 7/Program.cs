using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Matrix a = Matrix.Create();
            a.Fill();
            a.Display();

            Matrix b = Matrix.Create();
            b.Fill();
            b.Display();

            Console.WriteLine("a + b: ");
            var z = a + b;
            z.Display();

            Console.WriteLine("\na == b: {0}\n", a == b);
            Console.WriteLine("\na != b: {0}\n", a != b);

            Console.WriteLine("Matrix norm from matrix a: {0}", a.Norm());


            Set s = new Set();
            s.Fill();
            s.Display();
            s.Add(5);
            s.Display();
            s.Delete(5);
            s.Display();
            Console.WriteLine("\n\nIs 123 in set: {0}", s.Check(123));
            Console.WriteLine("\n\nCounting numbers: {0}", s.Count());
            var x = new Set();
            x.Fill();
            x.Display();
            var c = new Set();
            Console.WriteLine("Cross Sets: ");
            c = c.СrossSets(x, s);
            c.Display();

            Console.WriteLine("Union Sets: ");
            c = c.UnionSets(x, s);
            c.Display();

            Console.WriteLine("x minus s: ");
            c = x - s;
            c.Display();

            Console.WriteLine("x == s: {0}", x == s);
            Console.WriteLine("x == s: {0}", x != s);



        }
    }
}