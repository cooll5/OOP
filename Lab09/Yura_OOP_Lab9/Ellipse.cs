using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    public class Ellipse : Function
    {
        private int x;
        private int a;
        private int b;
        public int GetX() { return x; }
        public int GetA() { return a; }
        public int GetB() { return b; }
        public void SetX(int A) { x = A; }
        public void SetA(int A) { a = A; }
        public void SetB(int A) { b = A; }
        public Ellipse() { x = 1; a = 1; b = 1; }
        public Ellipse(int A, int B, int C) { x = A; a = B; b = C; }
        public Ellipse(Ellipse A) { x = A.x; a = A.a; b = A.b; }
        public override double Y()
        {
            return Math.Sqrt((1 - ((x * x) / (a * a))) * (b * b));
        }
        public override string ToString()
        {
            return $"y = f({x}) then y = {Y()}";
        }
    }
}
