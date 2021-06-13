using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            StartGame();


        }
        public static void StartGame()
        {
                while (true)
                {
                    Random random = new Random();
                    int guessNumber = random.Next(1, 10);

                    int guess = 0;
                    Console.WriteLine("Please guess a number between 1 and 10.");

                    while (guess != guessNumber)
                    {
                        string input = Console.ReadLine();
                        guess = Int32.Parse(input);

                        if (guess != guessNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not correct. Please try again!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Win!");
                            Console.ResetColor();
                        }
                    }

                    Console.WriteLine("Do you want to play again? [Y or N]");

                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }

            
        }
    }
}
