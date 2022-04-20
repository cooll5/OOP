using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();
            c.Read();
            Console.Write("Your output is:");
            c.Display();
            Console.ReadKey();
        }
    }
}
