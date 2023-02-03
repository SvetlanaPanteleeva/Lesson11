using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Linearequation
    {
        double b;
        double k;

        public Linearequation(double k, double b)
        {
            this.b = b;
            this.k = k;
        }
        public string Root()
        {
            double x = -b / k;
            if (k == 0)
                return "Деление на 0 невозможно";
            else
                return $"x = {x}";
        }
    }
}
