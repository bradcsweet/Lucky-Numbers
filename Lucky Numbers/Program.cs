using System;
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
            //lucky numbers lottery with stretch task
            string playAgain;
            do
            {
                Console.WriteLine("\t\tWelcome to Balthazar's Mega $750,000 Jackpot! \nWhere guessing 6 numbers in a range YOU choose can win you BIG! Mega even!");
                Console.WriteLine("\nChoose a starting number for the lowest number in the number range.");
                int lowRange = int.Parse(Console.ReadLine());

                //user range. highrange must be larger than lowrange with enough span to pick 6 guesses
                int highRange = 0;
                do
                {
                    Console.WriteLine("Now choose the highest number in the number range");
                    highRange = int.Parse(Console.ReadLine());

                } while (highRange <= lowRange + 4);
                
                Console.WriteLine("Guess six unique numbers in that range that you think are the LUCKY NUMBERS");

                //user guesses
                int[] userNumbers = new int[6];
                for (int i = 0; i < userNumbers.Length; i++)
                {
                    Console.WriteLine("Enter a number. Press \"Enter\"");
                    int userNumber = int.Parse(Console.ReadLine());
                    while (userNumber < lowRange || userNumber > highRange)
                    {
                        Console.WriteLine("Number is out of range and not valid. Enter a number between " + lowRange + " and " + highRange + ".");
                        userNumber = int.Parse(Console.ReadLine());
                    }
                    userNumbers[i] = userNumber;
                }
                
                //random number generator with no duplicate numbers
                int[] luckyNumbers = new int[6];
                Random randoNumber = new Random();
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    int luckyNumber = randoNumber.Next(lowRange, highRange + 1);
                    if (!luckyNumbers.Contains(luckyNumber))
                    {
                        luckyNumbers[i] = luckyNumber;
                    }
                    else
                    {
                        i--;
                    }
                }
                
                //displaying random numbers
                foreach (int luckyNumber in luckyNumbers)
                {
                    Console.WriteLine("Lucky Number: " + luckyNumber);
                }

                //comparing arrays for matches between user and random generated numbers
                double numberMatches = 0;
                foreach (int userNumber in userNumbers)
                {
                    foreach (int luckyNumber in luckyNumbers)
                    {
                        if (userNumber == luckyNumber)
                        {
                            numberMatches++;
                        }
                    }
                }

                Console.WriteLine("You guessed " + numberMatches + " correctly!");
                
                //jackpot!
                double jackpotTotal = 750000;
                double userWinnings = (jackpotTotal) * (numberMatches/6);

                Console.WriteLine("\n\nAnd now to reveal what you've won!\n\nPress\"Enter\"");
                Console.ReadLine();
                Console.WriteLine("You won $" + userWinnings + "!");

                Console.WriteLine("\nDo you want to play again? (YES/NO)");
                playAgain = Console.ReadLine().ToUpper();
                Console.Clear();

            } while (playAgain == "YES");

            Console.WriteLine("\nThanks for playing!");

        }













    }
}

