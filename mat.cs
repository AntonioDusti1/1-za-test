using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_ispit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            double x;
            a = 3;
            b = 4;
            c = 2.5;
            d = 5;
            x = (a * a + b * b + c * c + d * d) / ((a + b) * (a + b) + (c + d) * (c + d));
            Console.Write("Broj x je ", x);
            Console.ReadLine();
        }
    }
}
