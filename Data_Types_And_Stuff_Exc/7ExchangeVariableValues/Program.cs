using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before:\na = {num1}\nb = {num2}");
            int FloatingNum = num1;
            num1 = num2;
            num2 = FloatingNum;
            Console.WriteLine($"After:\na = {num1}\nb = {num2}");
        }
    }
}
