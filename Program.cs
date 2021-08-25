using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Secret Number!");
            Console.WriteLine("Type a number between 1 and 100 and hit enter:");

            string response = Console.ReadLine();

            Console.WriteLine($"You guessed {response}. Interesting choice...");
        }
    }
}
