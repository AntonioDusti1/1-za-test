using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cijeli_decimalni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi cijeli i decimalni broj:");
            string input = Console.ReadLine();

            string[] broj = input.Split();
            int cijeli = int.Parse(broj[0]);
            double decimalni = double.Parse(broj[1]);

            Console.WriteLine("Cijeli: " + cijeli);
            Console.WriteLine("Decimalni broj: " + decimalni);
            Console.ReadLine();
        }
    }
}
