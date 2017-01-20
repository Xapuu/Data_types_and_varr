using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool output = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine((output==true)?"Yes":"No");
        }
    }
}
