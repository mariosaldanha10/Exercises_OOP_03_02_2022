using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP_03_02_2022.Exercises
{
    public class Question3
    {
        public Question3()
        {

        }
        public void randomNumbers()
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int usersGuess;
            int amountOfGuesses = 0;
            do
            {
                Console.WriteLine("Guess the random number");
                usersGuess = int.Parse(Console.ReadLine());
                if (usersGuess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low");
                }
                else if (usersGuess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else
                {
                    Console.WriteLine("Your guess is correct");
                }
                amountOfGuesses++;

            } while (usersGuess != randomNumber);
            Console.WriteLine("You guessed {0} times", amountOfGuesses);
        }
    }
}
