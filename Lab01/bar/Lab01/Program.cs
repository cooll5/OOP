using System;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            double x; 
            double y; // result
            double A = 0; // сталий вираз
            double B = 0; // змінний вираз
            Console.WriteLine("Task 1:");
            Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

            A = 1 + x;
                 if (x <= 4)
                B = Math.Exp(Math.Log(2 + 2 * 2) + 2 * x);
            else
                 if (x > 7)
                B = 1 - 7 * x + 2 * x * x - Math.Pow(2 * x, 3);
            else
                B = 1 / Math.Tan((1 + x) / 9 + 8 * x);

            y = A + B;

            Console.WriteLine($" y =  {y}  \n");

            //Task 2
            Console.WriteLine("Task 2:");

            double a; 
            double b; 
            double c; 
            double F = 0; // результат обчислення

            Console.WriteLine("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c = "); c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());


            if (c < 0 && x != 0)
                F = (-a) * x - c;

            else
                if (c > 0 && x == 0)
                F = (x - a) / ( - c );

            else
                F = (b * x)/ (c - a);

            Console.WriteLine($" F =  {F}");

            //Task 3
            Console.WriteLine("Task 3:");

            int i = 1, N;

            double S;

            Console.WriteLine("N = "); N = Convert.ToInt32(Console.ReadLine());

            S = 0;
            i = 1;
            while (i <= N)
            {
                S += ((1 + i / N)/ (i * i));
                i++;
            }
            Console.WriteLine($"1) S =  {S}");

            S = 0;
            i = 1;
            do
            {
                S += ((1 + i / N) / (i * i));
                i++;
            }
            while (i <= N);
            Console.WriteLine($"2) S =  {S}");

            S = 0;
            for (i = 1; i <= N; i++)
            {
                S += ((1 + i / N) / (i * i));
            }
            Console.WriteLine($"3) S =  {S}");

            S = 0;
            for (i = N; i >= 1; i--)
            {
                S += ((1 + i / N) / (i * i));
            }
            Console.WriteLine($"4) S =  {S}");


            //Task 4
            Console.WriteLine("Task 4:");
            double xp, xk, dx;

            Console.WriteLine("xp = "); xp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("xk = "); xk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dx = "); dx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a = "); a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = "); b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c = "); c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------------");
            Console.WriteLine("|     x     |     F     |");

            x = xp;
            while (x <= xk)
            {
                if (c < 0 && x != 0)
                    F = (-a) * x - c;
                else
                    if (c > 0 && x == 0)
                    F = (x - a) / (-c);
                else
                    F = (b * x) / (c - a);

                Console.WriteLine($"|      {x}  |      {F}  |");
                x += dx;
            }
            Console.WriteLine("---------------------------");

        }
    }
}
