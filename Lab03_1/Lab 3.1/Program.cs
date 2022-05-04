using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3._1
{
    class Program
    {
        static int Countw(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int b = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    b++;
                }
            }
            return b;
        }
        static int Counth(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'b')
                {
                    a++;
                }
            }
            return a;
        }
        static int Counte(string str)
        {
            if (str.Length < 1)
            {
                return 0;
            }
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'c')
                {
                    c++;
                }
            }
            return c;
        }
        static string Change(string str)
        {
            string stringer;
            if (str.Length < 1)
            {
                return str;
            }
            else
            {
                stringer = str.Replace("abc", "**");
            }
            return stringer;
        }

       
        static void Main(string[] args)
        {
            string str;Console.WriteLine("Task 1");
            Console.WriteLine("===========================================");

            Console.WriteLine("Enter string:");
            str = Console.ReadLine();
            string str_modified;
            str_modified = Change(str);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"String: {str}");
            Console.WriteLine($"New string: {str_modified}");
            Console.WriteLine("===========================================");

            Console.WriteLine("Task 2");
            
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count++;
                }
            }
            {
                Console.WriteLine("The reminds of 'a' in the context:" + count);
                Console.WriteLine("===========================================");
            }

            Console.ReadKey();
        }
    }
}