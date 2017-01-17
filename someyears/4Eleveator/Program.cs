using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Eleveator
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int cap = int.Parse(Console.ReadLine());
            double course = Math.Ceiling((double)person / cap);

            Console.WriteLine(course);


        }
    }
}
