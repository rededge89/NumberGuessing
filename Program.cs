using System;
using System.Globalization;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool stopGame = false;

            do
            {
                int winningNumber = rand.Next(0, 100);
                bool win = false;
                do
                {
                    bool numValid = true;
                    string userNum;
                    int i;
                    do
                    {
                        numValid = true;
                        Console.Write("Guess a number between 0 and 100: ");
                        userNum = Console.ReadLine();
                        
                        if (!int.TryParse(userNum, out i))
                        {
                            Console.WriteLine("You entered an invalid number, please try again.");
                            numValid = false;
                        }
                        else
                        {
                            i = int.Parse(userNum);
                        }
                    } while (numValid == false);
                    
                    if (i > winningNumber)
                    {
                        Console.WriteLine("Your number is too high!");
                    }
                    else if (i < winningNumber)
                    {
                        Console.WriteLine("Your number is too low!");
                    }
                    else
                    {
                        Console.WriteLine("You are a winner!!");
                        win = true;
                    }
                } while (win == false);
                
                Console.Write("Would you like to play again? (y/n)");
                string userResponse = Console.ReadLine();
                if (userResponse == "n")
                {
                    stopGame = true;
                }
            } while (stopGame == false);
        }
    }
}