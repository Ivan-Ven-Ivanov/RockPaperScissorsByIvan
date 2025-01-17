﻿namespace RockPaperScissors
{
    public class RockPaperScissors
    {
        static void Main(string[] args)
        {
            while (true)
            {
                const string Rock = "Rock";
                const string Paper = "Paper";
                const string Scissors = "Scissors";

                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.WriteLine("Ivalid Input. Try Again...");
                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.WriteLine($"The computer chose {computerMove}.");

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Scissors && computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                }
                else if ((playerMove == Rock && computerMove == Paper) ||
                    (playerMove == Scissors && computerMove == Rock) ||
                    (playerMove == Paper && computerMove == Scissors))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a draw");
                }

                Console.ResetColor();
                while (true)
                {
                    Console.Write("Do you want to play again? [yes] [no] ");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        break;
                    }
                    else if (playAgain == "no")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer");
                        continue;
                    }
                }
            }
        }
    }
}