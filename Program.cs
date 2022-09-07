using System;

namespace NumberGuesser
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(
                "    Welcome to the amazing Number Guesser! Don't be spooked once it's Guessed right.!  "
            );
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            {
                DisplayGreeting();
                int lowest = 1;
                int highest = 1024;
                int differenceOfRange = highest - lowest;
                int midpoint = differenceOfRange / 2;
                int midValue = lowest + midpoint;
                bool secretNumber = true;

                Console.WriteLine(
                    "Think of a number between 1 to 1024. Please, do not say it out loud... It'll make it easier. Press enter to continue"
                );
                Console.ReadKey();
                while (lowest <= highest && secretNumber)
                //while low # is less or equal to the highest # and the secretNumber is true
                {
                    differenceOfRange = highest - lowest;
                    midpoint = differenceOfRange / 2;
                    midValue = lowest + midpoint;
                    //The middle of 1 - 1025 is 512
                    Console.WriteLine(
                        "Something is telling me that this is your number: {0}",
                        midValue
                    );
                    //User telling the computer if the # is too low or too high or right
                    Console.WriteLine(
                        " 1: Wrong, number is lower\n 2: Wrong, number is higher \n 3: Wohoo, let's party that is right "
                    );
                    //prompt returns a string so we have to use int.Parse to convert the string to an integer
                    int userChoiceToInt = int.Parse(Console.ReadLine());
                    //we create a variable userChoice to store the integer
                    int userChoice = userChoiceToInt;
                    //we check what option the user selected
                    if (userChoice == 3)
                    {
                        Console.WriteLine("My magical powers worked again");
                        secretNumber = false; //the number is not longer secret therefore is false
                    }

                    if (lowest < highest && userChoice == 2)
                    {
                        lowest = midValue + 1;
                        Console.WriteLine("Your number was {0}", midValue);
                    }
                    else if (lowest < highest && userChoice == 1)
                    {
                        highest = midValue - 1;
                        Console.WriteLine("Your number was {0}", midValue);
                    }
                }
            }
        }
    }
}
