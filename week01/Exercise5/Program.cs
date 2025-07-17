using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PrompUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string value = Console.ReadLine();
            int number = int.Parse(value);
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"Brother {userName}, the square of your number is {square}");
        }

        DisplayWelcome();

        DisplayResult(PrompUserName(), SquareNumber(PromptUserNumber()));

    }
}