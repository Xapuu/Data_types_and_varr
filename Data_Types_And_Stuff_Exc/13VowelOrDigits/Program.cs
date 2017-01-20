using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13VowelOrDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int value;

            if (int.TryParse(input, out value))
            {
                Console.WriteLine("digit");
            }
            else if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
           
        }
    }
}
