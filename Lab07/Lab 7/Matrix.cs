using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Matrix
    {
        private int N;
        private int[,] mat;

        public Matrix()
        {
            this.N = 0;
            this.mat = new int[N, N];
        }
        public Matrix(int n)
        {
            if (n > 0)
            {
                this.N = n;
                this.mat = new int[N, N];
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < N; j++)
                        mat[i, j] = 0;
            }
        }
        public Matrix(Matrix m)
        {
            this.N = m.N;
            this.mat = m.mat;
        }
        public static Matrix Create()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Input number of lines and rows:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (!(n > 0));

            return new Matrix(n);
        }
        public void Fill()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"m[{i},{j}] =");
                    this.mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                { Console.Write("{0} ", mat[i, j]); }
                Console.WriteLine();
            }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.N == b.N)
            {
                var matrix = new Matrix(a.N);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    { matrix.mat[i, j] = a.mat[i, j] + b.mat[i, j]; }
                }
                return matrix;
            }
            else
            {
                Console.WriteLine("Both matrix must have equal size!");
                return new Matrix();
            }
        }


        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.N == b.N)
            {
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    {
                        if (a.mat[i, j] != b.mat[i, j])
                        { return false; }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            if (a.N == b.N)
            {
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    {
                        if (a.mat[i, j] != b.mat[i, j])
                        { return true; }
                    }
                }
                return false;
            }
            else
            { return true; }
        }

        public double Norm()
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                { sum += Math.Pow(mat[i, j], 2); }
            }
            return Math.Round(Math.Sqrt(sum), 2);
        }


    }
}
