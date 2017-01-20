using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Math.Truncate(double.Parse(Console.ReadLine()) * 1000000);
            double num2 = Math.Truncate(double.Parse(Console.ReadLine()) * 1000000);

            Console.WriteLine((num1 == num2));

        }
    }
}
