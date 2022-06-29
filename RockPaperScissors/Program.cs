using System;

namespace PaperRockScissors
{
    internal class Program
    {
        static readonly string[] options = { "Paper", "Rock", "Scissors" };

        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Welcome to Paper, Rock, Scissors");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.WriteLine("What is your selection?");
            Console.Write("[ Paper, Rock, Scissors ]? ");

            string userInput = Console.ReadLine();
            string compInput = ComputerSelection();

            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.WriteLine($"You chose {userInput}.");
            Console.WriteLine($"The computer chose {compInput}.");
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("");

            int result = Outcome(userInput, compInput);

            if (result == 0)
            {
                Console.WriteLine("It's a tie!");
            } else if(result == -2 || result == 1)
            {
                Console.WriteLine("The computer wins!");
            } else
            {
                Console.WriteLine("You win!");
            }
        }

        static string ComputerSelection()
        {
            
            Random index = new();

            return options[index.Next(3)];
        }

        static int Outcome(string userSelection, string compSelection)
        {
            /*
             Winning Calculations:
                -2 = loser
                -1 = winner
                0 = tie
                1 = loser
                2 = winner
            */

            return Array.IndexOf(options, userSelection) - Array.IndexOf(options, compSelection);
        }
    }
}