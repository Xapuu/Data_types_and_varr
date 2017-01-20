using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int dist = int.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float m = float.Parse(Console.ReadLine());
            float s = float.Parse(Console.ReadLine());

            float time = h*3600+m*60+s;

            float MetersInSecond = (float)(dist /(float) time);
            float KmInHour = (float)((dist/1000.0)/(float)(time/3600)); 
            float MilesInHour = (float)(dist/1609.0)/(float)(time/3600);

           
           
            
            Console.WriteLine($"{MetersInSecond:0.######}\n{KmInHour:0.######}\n{MilesInHour:0.######}");

        }
    }
}
