using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ReeverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            short Centuries = short.Parse(Console.ReadLine());
            int years = (int)Centuries * 100;
            int days = (int)(years * 365.242199);
            uint hours = (uint)days * 24;
            decimal minutes = (decimal)hours * 60;
            decimal seconds = minutes * 60;
            decimal miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = 1000000 * miliseconds;

            Console.WriteLine($"{Centuries} centuries = {years} years = {days:0.} days = {hours} hours = {minutes} minutes = {seconds} seconds" +
                $" = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
