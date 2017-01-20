using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            String LastName = Console.ReadLine();
            short age = short.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long PersonalId = long.Parse(Console.ReadLine());
            long UEN = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nAge: {age}"+
                $"\nGender: {sex}\nPersonal ID: { PersonalId}\nUnique Employee number: { UEN} ");
        }
    }
}
