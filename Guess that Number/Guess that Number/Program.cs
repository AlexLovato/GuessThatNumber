using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_that_Number
{
    class Program
    {
        static void Main(string[] args)
        {//greet them
           Console.WriteLine("Let's play a game.");
            //call game function
           GameFunction();
            //ask if they wanna play again
           Console.WriteLine("would you like to play again?");
           string answer = Console.ReadLine();
            //put their answer to lowercase for comparison
           string lower = answer.ToLower();
            //test their answer
           if (lower == "yes" || lower == "y")
           {//if they type yes call game function 
               GameFunction();
           }
               //their answer isn't yes so tell them bye
           else Console.WriteLine("peace out, dude");
        }
        static void GameFunction()
        {
            //make the computer think of a random number
            Console.WriteLine("I am thinking of a number.");
            //generate random number between including 2 and 100
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 101);
            //ask for a guess
            Console.WriteLine("Type in your guess. :");
            int intInput = 0;
            //while their guess is incorrecct
            while (intInput != randomNumber)
            { //ask for a guess and tell them whether it's greater or lower than their guess
                string newInput = Console.ReadLine();
                intInput = Convert.ToInt32(newInput);
                Console.WriteLine("nope, not " + newInput);
                if (intInput > randomNumber)
                {
                    Console.WriteLine("your guess was too high");
                }
                else if (intInput < randomNumber)
                {
                    Console.WriteLine("your guess is too small");
                }

            }
            //tell them they win if intInput == randomNumber (else)
            Console.WriteLine(intInput + "was correct, you win!");
            Console.ReadKey();
        }
    }
}
