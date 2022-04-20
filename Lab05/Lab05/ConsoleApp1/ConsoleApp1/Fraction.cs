using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Fraction
    {
        private int wholePart;
        private uint fractionPart;

        public double ToDouble()
        {
            var s = wholePart + "," + fractionPart;

            return Convert.ToDouble(s);
        }

        public override string ToString()
        {
            return this.ToDouble().ToString("n2");
        }

        public static Fraction ToFraction(double value)
        {
            var arr = value.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            return new Fraction()
            {
                wholePart = Convert.ToInt32(arr[0]),
                fractionPart = arr.Length == 2 ? Convert.ToUInt32(arr[1]) : 0
            };
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return ToFraction(a.ToDouble() + b.ToDouble());
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return ToFraction(a.ToDouble() - b.ToDouble());
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return ToFraction(a.ToDouble() * b.ToDouble());
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return ToFraction(a.ToDouble() * b.ToDouble());
        }
    }

}
