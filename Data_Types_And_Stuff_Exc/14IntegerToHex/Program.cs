using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14IntegerToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hex = num.ToString("X");
            string bin = Convert.ToString(num, 2);
            Console.WriteLine($"{hex}\n{bin}");

        }
    }
}
