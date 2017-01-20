using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15FastPrimeRefac
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitNumber = int.Parse(Console.ReadLine());
            for (int startNumber = 2; startNumber <= limitNumber; startNumber++)
            {
                bool answer = true;
                for (int test = 2; test <= Math.Sqrt(startNumber); test++)
                {
                    if (startNumber % test == 0)
                    {
                        answer = false;
                        break;
                    }
                }
                Console.WriteLine($"{startNumber} -> {answer}");
            }

        }
    }
}
