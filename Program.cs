using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);

            int turnCounter = 0;

            Console.WriteLine("Guess the Secret Number!");
            Console.WriteLine("Type a number between 1 and 100 and hit enter:");

            int response = int.Parse(Console.ReadLine());

            while (turnCounter < 4)
            {
                if (response == secretNumber) 
                {
                    Console.WriteLine("Congrats, you guessed the secret number!");
                    break;
                }
                else
                {
                    string guessString = "guesses";
                    if ((4-turnCounter) == 1)
                    {
                        guessString = "guess";
                    }
                    turnCounter++;
                    Console.WriteLine($"{response} is not the secret number. You have {5-turnCounter} {guessString} left. Try again:");
                    response = int.Parse(Console.ReadLine());
                }
            }

            if (response != secretNumber)
            {
                Console.WriteLine("Sorry, you've used all your guesses. You lose");
            }
        }
    }
}
