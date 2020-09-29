using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string userinput;
            int randomnuber;                     
            int UserScore = 0;
            int ComputerScore = 0;
            Console.WriteLine("Enter Rock, paper or scissors:");

            while (UserScore < 3 && ComputerScore < 3)
            {
                userinput = Console.ReadLine().ToLower();                
                randomnuber = rnd.Next(1, 4);

                if (randomnuber == 1 && userinput == "paper")
                {
                    Console.WriteLine("Tie!,next rount:");
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else if (randomnuber == 1 && userinput == "scissors")
                {
                    Console.WriteLine("You win round, next round:");
                    UserScore = UserScore + 1;
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else if (randomnuber == 1 && userinput == "rock")
                {
                    Console.WriteLine("You lose round, next round:");
                    ComputerScore = ComputerScore + 1;
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else if (randomnuber == 2 && userinput == "paper")
                {
                    Console.WriteLine("you win round,next rount:");
                    UserScore = UserScore + 1;
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else if (randomnuber == 2 && userinput == "scissors")
                {
                    Console.WriteLine("You lose round, next round:");
                    ComputerScore = ComputerScore + 1;
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else if (randomnuber == 2 && userinput == "rock")
                {
                    Console.WriteLine("Tie, next round:");
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");

                }
                else if (randomnuber == 3 && userinput == "paper")
                {
                    Console.WriteLine("You lose round,next rount:");
                    ComputerScore = ComputerScore + 1;
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else if (randomnuber == 3 && userinput == "scissors")
                {
                    Console.WriteLine("Tie, next round:");
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else if (randomnuber == 3 && userinput == "rock")
                {
                    Console.WriteLine("You win round, next round:");
                    UserScore = UserScore + 1;
                    Console.WriteLine($"computer have {ComputerScore} points.");
                    Console.WriteLine($"You have {UserScore} points.");
                }
                else Console.WriteLine("unknown input. try agian: rock, paper, or scissors");
            }

                if (UserScore == 3)
                {
                    Console.WriteLine("You won!!");
                }
                else if (ComputerScore == 3)
                {
                    Console.WriteLine("you lost");
                }
                
                
            
        }
    }
}
