using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17PrintPartOfASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = Convert.ToInt32(Console.ReadLine());

            for (int i = firstChar; i <= lastChar; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
