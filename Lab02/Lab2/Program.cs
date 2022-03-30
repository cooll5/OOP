using System;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            //Task 1
            Console.WriteLine("Task 1");
            Random rnd = new Random();
            const int n = 26;
            int[] a = new int[n];

            int low = -40;
            int high = 20;

            for (int i = 0; i < n; i++)
                a[i] = low + rnd.Next() % (high - low + 1);

            Console.Write("a[] = {");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} , ");

            }
            Console.WriteLine("}");
            Console.WriteLine();

            int S = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
                if (a[i] > 0 || i % 2 != 0)
                {
                    S += a[i];
                    k++;
                    a[i] = 0;
                }

            Console.WriteLine($"Number = {k}");
            Console.WriteLine($"Sum = {S}");
            Console.WriteLine();
            Console.Write("a[] = {");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} , ");
            }
            Console.WriteLine("}");
            Console.WriteLine();

            //Task 2
            Console.WriteLine("Task 2");
            int[] A = { 12, 24, 41, 76, 32, 69, 10, 90, 39, 20, 41, 65, 34, 87, 23};

            static int result_minimum(int[] A)
            {
                int min = A[0];

                for (int i = 0; i < 15; i++)
                {
                    if (A[i] < min)
                    {
                        min = A[i];
                    }
                }
                return min;
            }
            static int result_maximum(int[] A)
            {
                int max = A[0];
                for (int i = 0; i < 15; i++)
                {
                    if (A[i] > max)
                    {
                        max = A[i];

                    }
                }
                return max;
            }
            int avarage(int max, int min)
            {
                int conclution = 0;
                conclution = (max + min) / 2;
                return conclution;
            }

            void output()
            {
                int min = result_minimum(A);
                int max = result_maximum(A);
                int avar = avarage(max, min);

                Console.WriteLine("Min = " + min);
                Console.WriteLine("Max = " + max);
                Console.WriteLine("Avarage = " + avar);
            }

            output();

            //Task 3
            Console.WriteLine("Task 3");

            int row = 4;
            int column = 4;

            int[,] ab = new int[row, column];

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    ab[i, j] = low + rnd.Next() % (high - low + 1);

            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                    Console.Write($"{ab[i, j]} \t");

                Console.WriteLine();
            }

            Console.WriteLine();
            S = 0;
            for (int i = 0; i < row; i++)
            {
                int min = ab[i, 0];
                for (int j = 1; j < column; j++)
                    if (ab[i, j] < min) min = ab[i, j];
                S += min;
            }

            Console.WriteLine($"Sum = {S}");
            Console.WriteLine();
        }
    }
}
