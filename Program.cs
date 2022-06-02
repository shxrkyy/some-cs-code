using System;

namespace Terminator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Appearance

            Console.Title = "Terminator v0.0.1 PRE-ALPHA";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WindowHeight = 40;

            // Login

            Console.WriteLine("What is your username?");

            string userName = Console.ReadLine();

            Console.WriteLine("What is your password?");

            string password = Console.ReadLine();

            // Welcome

            Console.WriteLine("Welcome, " + userName + " to Terminator!\n Version: 0.0.1 PRE-ALPHA (Up to Date)");

            // Console

            Console.ReadKey();
        }
    }
}
