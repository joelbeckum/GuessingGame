using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            Console.WriteLine("Guess the Secret Number!");
            Console.WriteLine("Type a number between 1 and 100 and hit enter:");

            int response = int.Parse(Console.ReadLine());

            if (response == secretNumber) 
            {
                Console.WriteLine("Congrats, you guessed the secret number!");
            }
            else
            {
                Console.WriteLine($"{response} is not the secret number. That's too bad...");
            }
        }
    }
}
