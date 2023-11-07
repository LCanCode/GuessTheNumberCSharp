// See https://aka.ms/new-console-template for more information
using System;

namespace NumberGuessingGame
  {
    class Program
    {
      static void Main(string[] args)
      {
          Random r = new Random();

          int winNum = r.Next(0, 100);

          bool win = false;

          do 

          {
            Console.Write("Guess a number between 0-100");
            string s = Console.ReadLine();
            int i = int.Parse(s);

            if (i > winNum)
            {
              Console.WriteLine("too high, guess again");
            }
            else if (i < winNum)
            {
              Console.WriteLine("too low, guess again");
            }
            else if (i == winNum)
            {
              Console.WriteLine("Correct Guess, you win");
              win = true;
            }
            Console.WriteLine();

          } while (win == false);
          Console.WriteLine("Thanks for playing");
          Console.Write("Press any key to finish");
          Console.ReadKey(true);
      }
    }
  }