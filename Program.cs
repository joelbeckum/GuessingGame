using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);

            int turnCounter = 0;
            int difficultyLevel = 0;

            Console.WriteLine("Guess the Secret Number!");
            Console.WriteLine("Please enter a difficulty level between 1 and 3:");
            while(difficultyLevel == 0)
            {
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        difficultyLevel = 1;
                        turnCounter = 8;
                        Console.WriteLine("Difficulty set to 'easy.' You have eight guesses to find the secret number.");
                        break;

                    case 2:
                        difficultyLevel = 2;
                        turnCounter = 6;
                        Console.WriteLine("Difficulty set to 'medium.' You have six guesses to find the secret number.");
                        break;

                    case 3:
                        difficultyLevel = 3;
                        turnCounter = 4;
                        Console.WriteLine("Difficulty set to 'hard.' You have four guesses to find the secret number.");
                        break;

                    default:
                        Console.WriteLine("You must enter a number between 1 and 3 to continue:");
                        break;
                }
            }

            Console.WriteLine("Type a number between 1 and 100 and hit enter:");

            int response = int.Parse(Console.ReadLine());

            while (turnCounter > 1)
            {
                if (response == secretNumber) 
                {
                    Console.WriteLine("Congrats, you guessed the secret number!");
                    break;
                }
                else
                {
                    string highLowString = "too high";
                    string guessString = "guesses";
                    if (turnCounter == 2)
                    {
                        guessString = "guess";
                    }
                    if (response < secretNumber)
                    {
                        highLowString = "too low";
                    }
                    
                    turnCounter--;
                    Console.WriteLine($"{response} is {highLowString}. You have {turnCounter} {guessString} left. Try again:");
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
