﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain;
            do
            {
                Console.WriteLine("What is the lowest number in the number range?");
                int lowRange = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the highest number in the number range?");
                int highRange = int.Parse(Console.ReadLine());

                Console.WriteLine("Guess six numbers in that range that you think are the LUCKY NUMBERS");

                int[] userNumbers = new int[6];
                for (int i = 0; i < userNumbers.Length; i++)
                {
                    Console.WriteLine("Enter a number");
                    int userNumber = int.Parse(Console.ReadLine());
                    while (userNumber < lowRange || userNumber > highRange)
                    {
                        Console.WriteLine("Number is out of range and not valid. Enter a number between " + lowRange + " and " + highRange + ".");
                        userNumber = int.Parse(Console.ReadLine());
                    }
                    userNumbers[i] = userNumber;
                }


                int[] luckyNumbers = new int[6];
                Random randoNumber = new Random();
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    int luckyNumber = randoNumber.Next(lowRange, highRange + 1);
                    luckyNumbers[i] = luckyNumber;
                }


                foreach (int luckyNumber in luckyNumbers)
                {
                    Console.WriteLine("Lucky Number: " + luckyNumber);
                }

                int numberMatches = 0;

                for (int i = 0; i < userNumbers.Length; i++)
                {
                    for (int j = 0; j < luckyNumbers.Length; j++)
                    {
                        if (userNumbers[i] == luckyNumbers[j])
                        {
                            numberMatches++;
                        }
                    }

                }

                Console.WriteLine("You guessed " + numberMatches + " correctly!");
                int jackpotTotal = 750000;
                double userWinnings = (numberMatches / 6) * jackpotTotal;

                Console.WriteLine("You won " + userWinnings + "!");

                Console.WriteLine("Do you want to play again? (YES/NO)");
                string playAgain = Console.ReadLine().ToUpper();

            } while (playAgain == "Yes");

            Console.WriteLine("Thanks for playing!");

        }













    }
}
}
