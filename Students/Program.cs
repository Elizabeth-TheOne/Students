using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student susan = new Student("Susan");
            susan.NumberOfCredits = 45;

            Console.WriteLine(susan);
        }
    }
}
