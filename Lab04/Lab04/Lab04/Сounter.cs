using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Counter
    {

        private int sense;

        public int GetSense() { return sense; }

        public bool SetSense(int value)
        {
            if (value >= 0 && value < 100000) { sense = value; return true; }
            else Console.WriteLine("Try to write your value again!");
            { sense = 0; return false; }
            
        }

        public bool Init(int s)
        {
            return SetSense(s);
        }

        public void Read()
        {
            int s;

            do
            {
                Console.Write("Sense: ");
                s = Convert.ToInt32(Console.ReadLine());

            } while (!Init(s));
        }
        public void Display()
        {
            if (sense == 0)
                Console.Write($" {sense} - you have no value");
            else
                Console.Write($" {sense} that is your current value");

        }
    }
}

    


