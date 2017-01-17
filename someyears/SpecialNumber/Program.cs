using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int num_for_manip = i;
                int magick_num = 0;

                while (num_for_manip > 0 )
                {
                    magick_num += num_for_manip % 10;
                    num_for_manip /= 10;
                }

               string solution =  (magick_num == 5 || magick_num == 7 || magick_num == 11) ? "True" : "False";
                Console.WriteLine("{0} -> {1}", i, solution);
            }
        }
    }
}
