using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                SayHi();
                //Create a variable for the equation of code
                var lowestNum = 1;
                var highestNum = 1024;
                var differenceOfRange = highestNum - lowestNum;
                var midpointNum = differenceOfRange / 2;
                var midValueNumber = lowestNum + highestNum;
                //Bool if the magical number is = to true
                bool magicalNumber = true;

                //Now asking the user to guess their number
                Console.WriteLine(
                    "Pick a number between 1 and 1024 Please, do not say it out loud. \n Press enter or return to continue."
                );
                //Console Read Key is used so the user has to press a key on the keyboard to continue
                Console.ReadKey();

                //While the lowest number is less than/equal to the Highest number and the magical number is still true
                while (lowestNum <= highestNum && magicalNumber)
                {
                    //Telling the code to run the math equation to guess the number of the user
                    differenceOfRange = highestNum - lowestNum;
                    midpointNum = differenceOfRange / 2;
                    midValueNumber = lowestNum + midpointNum;
                    Console.WriteLine(
                        "Something is telling me that this is your number or close to it: {0}",
                        midValueNumber
                    );
                    //Asking the user for input
                    // using \n can space out sentences in Console WriteLine
                    // \n is useful for multi question answer
                    Console.WriteLine(
                        $" 1: Wrong, number is lower \n 2:Wrong, number is higher \n 3: Wahoo, you are a Magician!!"
                    );
                    // converting the number into readable code for the computer.
                    // making a double into a string essentially
                    double userChoiceConvert = Convert.ToDouble(Console.ReadLine());
                    double userChoice = userChoiceConvert;
                    // coding the 3 possible user inputs
                    // if user chooses either 2 or 3 the code will run a math equation
                    if (userChoice == 3)
                    {
                        Console.WriteLine("Am I a magician or what! You are welcome.");
                    }
                    if (lowestNum < highestNum && userChoice == 2)
                    {
                        lowestNum = midValueNumber + 1;
                        Console.WriteLine("Your number was {0}", midValueNumber);
                    }
                    else if (lowestNum < highestNum && userChoice == 1)
                    {
                        highestNum = midValueNumber - 1;
                        Console.WriteLine("Your number was {0}", midValueNumber);
                    }
                }
            }
        }

        //Method to say Hi. I can put it in the main code easily
        static void SayHi()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Welcome to the amazing number guesser!");
            Console.WriteLine("Don't be spooked once the number is guessed right!");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
