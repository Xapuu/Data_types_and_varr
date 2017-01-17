using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagickLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter = int.Parse(Console.ReadLine())+97;
            for (int x = 97; x < letter; x++)
            {
                
                for (int z = 97; z < letter; z++)
                {
                    
                    for (int i = 97; i < letter; i++)
                    {
                        Console.WriteLine((char)x+""+(char)z+""+(char)i);
                    }
                }
            }

            
        }
    }
}
