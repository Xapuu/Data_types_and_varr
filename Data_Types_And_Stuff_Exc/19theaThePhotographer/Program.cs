using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19theaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long amountOfPicturesTaken = long.Parse(Console.ReadLine());
            long filterTime = Convert.ToInt64(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine())/100;
            int uploadTime = Convert.ToInt32(Console.ReadLine());

            long goodPictures = (long)Math.Ceiling(((amountOfPicturesTaken * filterFactor)));
            long timeNeeded = (long)(amountOfPicturesTaken*filterTime+goodPictures*uploadTime);

            long seconds=(long)timeNeeded%60;
            long minutes=((timeNeeded-seconds)/60)%60;
            long hours=((timeNeeded-minutes*60-seconds)/3600)%24;
            long days=((timeNeeded-hours*3600-minutes*60-seconds)/3600)/24;
            

            Console.WriteLine($"{days}:{hours:00.}:{minutes:00.}:{seconds:00.}");

            TimeSpan result = TimeSpan.FromSeconds(timeNeeded);
            string fromTimeString = result.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(fromTimeString);
        }
    }
}
