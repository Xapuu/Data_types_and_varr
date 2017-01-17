using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea12digits
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double answer = Math.PI * r * r;

            Console.WriteLine("{0:F12}",answer);
        }
    }
}
