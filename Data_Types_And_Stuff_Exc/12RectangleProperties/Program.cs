using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double p = 2*(width + height);
            double area = width * height;
            double diag = Math.Sqrt(width * width + height * height);

            Console.WriteLine($"{p}\n{area}\n{diag}"); 
        }
    }
}
