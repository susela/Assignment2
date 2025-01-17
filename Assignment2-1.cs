using System;

namespace Assignment2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user's name
            Console.Write("Enter your Name: ");
            string userName = Console.ReadLine();

            // Get user's age with validation
            Console.Write("Enter your Age: ");
            int userAge;
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            // Check eligibility and display result
            Console.WriteLine(userAge >= 18
                ? $" {userName},Eligible to vote"
                : $" {userName},Not eligible to vote");

            // Keep console window open
            Console.ReadKey();
        }
    }
}