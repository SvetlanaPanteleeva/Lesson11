using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = Convert.ToDouble(Console.ReadLine());
            double k = Convert.ToDouble(Console.ReadLine());

            Linearequation linearequation = new Linearequation(k, b);
            Console.WriteLine(linearequation.Root());
            Console.ReadKey();
        }
    }
}
