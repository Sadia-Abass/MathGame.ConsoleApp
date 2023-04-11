using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.ConsoleApp
{
    internal class Menu
    {
        GameEngine gamesEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            //Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. it's {date}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                    V - View Previous Games Scores
                    A - Addition
                    S - Substraction 
                    M - Multiplication
                    D - Division
                    Q - Quit the program");
                Console.WriteLine("------------------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gamesEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gamesEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gamesEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gamesEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye!");
                        isGameOn = false;
                        //Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
