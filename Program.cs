using System;
using System.Collections.Generic;
using cs_rock_paper_scissors.Models;

namespace cs_rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            while (playing)
            {
                Console.WriteLine("Please enter a Number:");
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                string selection = Console.ReadLine();
                int number;
                Console.Clear();
                if ((selection == "Q") || (selection == "q"))
                {
                    playing = false;
                    return;
                }
                else if (Int32.TryParse(selection, out number) && ((number == 1) || (number == 2) || (number == 3)))
                {
                    Console.WriteLine($"Your selection: {number}");
                    Random rand = new Random();
                    int randShoot = rand.Next(1, 4);
                    int randQuote = rand.Next(1, 11);
                    Console.WriteLine($"Computer selection: {randShoot}");
                    if (number == randShoot)
                    {
                        
                        Console.WriteLine($"The Game is a Draw!");
                    }
                    if ((number == 1) && (randShoot == 2))
                    {
                        
                        Console.WriteLine($"Paper Beats Rock - You Lose!");
                    }
                    if ((number == 1) && (randShoot == 3))
                    {
                        
                        Console.WriteLine($"Rock Smashes Scissors - You Win!");
                    }
                    if ((number == 2) && (randShoot == 1))
                    {
                        
                        Console.WriteLine($"Paper Cover Rock - You Win!");
                    }
                    if ((number == 2) && (randShoot == 3))
                    {
                        
                        Console.WriteLine($"Scissors Chop Paper - You Lose!");
                    }
                    if ((number == 3) && (randShoot == 1))
                    {
                       
                        Console.WriteLine($"Rock Smashes Scissors - You Lose!");
                    }
                    if ((number == 3) && (randShoot == 2))
                    {
                        
                        Console.WriteLine($"Scissors Chop Paper - You Win!");
                    }

                }
                else
                {
                Console.WriteLine("Please select a number 1-3! (or enter 'Q' to quit)");
                }

            }
        }
    }
}
