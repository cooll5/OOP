using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    public abstract class Function
    {
        public virtual double Y()
        {
            return 43 - 34 * 45;
        }
        public virtual string ToString()
        {
            return $"y = f(x)";
        }
    }
}
