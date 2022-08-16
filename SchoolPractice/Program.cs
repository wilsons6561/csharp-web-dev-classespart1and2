using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student spencer = new Student("Spencer Wilson", 123, 1, 4.0);

            Console.WriteLine("Student Name: " + spencer.Name);
        }
    }
}
