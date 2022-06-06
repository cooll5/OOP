using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Circle : Point
    {
        private double radius;
        public Circle() { this.SetX(0); this.SetY(0); this.SetR(1); }

        public Circle(double x, double y, double r) { this.SetX(x); this.SetY(y); this.SetR(r); }

        public void SetR(double value)
        {
            if (value > 0)
                this.radius = value;
            else
                this.radius = 1;
        }

        public double Square()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public void CircleDisplay()
        {
            Console.WriteLine($"Circle's center is on O ({GetX()};{GetY()}) and r = {radius}\nSquare = {Square()}");
        }

    }
}
