using System;

namespace GradesSwitchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter grade: ");
            string grade = Console.ReadLine();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Awesome!");
                    break;
                case "B":
                    Console.WriteLine("Good job");
                    break;
                default:
                    Console.WriteLine("keep trying");
                    break;
            }
        }
    }
}
