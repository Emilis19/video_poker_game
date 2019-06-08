using System;
using System.Linq;

namespace video_poker
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Video poker game");
              while (true)
              {
                  Console.WriteLine("Choose command:\n"
                  + "\n0: - Play the game\n"
                  + "1: - Exit\n"
                  + "Enter your choice: ");
                  try
                  {
                      int input = Convert.ToInt32(Console.ReadLine());
                      switch (input)
                      {
                          case 0:
                              {
                                  Console.WriteLine("Play here");
                                  break;
                              }
                          case 1:
                              {
                                  Environment.Exit(0);
                                  break;
                              }
                          default:
                              {
                                  Console.WriteLine("Wrong input, try again");
                                  break;
                              }
                      }
                  }
                  catch
                  {
                  }
                  */
            Logic logic = new Logic();
            Console.WriteLine(logic.deck.Count);
            logic.DealFirstHand();
            Console.WriteLine(logic.hand.Count);
            Console.WriteLine(logic.deck.Count);
            logic.PrintHand();
            Console.WriteLine();
              Console.WriteLine("Input the indexes of the cards you want to replace (use spaces)");
              var replaceInput = Console.ReadLine();
              var indexes = replaceInput.Split(' ').Select(int.Parse).ToList();
              logic.ReplaceCards(indexes);
              logic.PrintHand();
              Console.WriteLine(logic.deck.Count);
        }
        }
    }
