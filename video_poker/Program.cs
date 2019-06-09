using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace video_poker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Video poker game");
            while (true)
            {              
                Console.WriteLine("\nChoose command:\n"
                + "\n0: - Play the game\n"
                + "1: - Exit\n"
                + "\nEnter your choice: ");
                try
                {                 
                    int input = Convert.ToInt32(Console.ReadLine());

                    switch (input)
                    {
                        case 0:
                            {
                                Console.WriteLine();
                                Logic logic = new Logic();
                                logic.DealFirstHand();
                                Console.WriteLine("\nDo you want to keep your cards? Type in yes or no");
                                var answer = Console.ReadLine();                               
                                while (answer != "yes" && answer != "no")
                                {
                                    Console.WriteLine("Are you even trying?");
                                    answer = Console.ReadLine();
                                }
                                if (answer == "no")
                                {
                                    Regex regex = new Regex(@"^[0-4]\s?([0-4]\s*)*$");
                                    Console.WriteLine("\nInput the indexes of the cards you want to replace (use spaces)");
                                    var replaceInput = Console.ReadLine();
                                    while (!regex.IsMatch(replaceInput) || replaceInput.Length > 9)
                                    {
                                        Console.WriteLine("Are you even trying");
                                        replaceInput = Console.ReadLine();
                                    }
                                        var indexes = replaceInput.Split(' ').Select(int.Parse).ToList();
                                        logic.ReplaceCards(indexes);
                                        Console.WriteLine("Changed\n");
                                        logic.PrintHand();
                                        Console.WriteLine("\n Your score "+logic.PrintPrize());                              
                                }
                                else
                                {
                                    Console.WriteLine("\nYou kept your cards!\n");
                                    logic.PrintHand();
                                    Console.WriteLine("\n"+logic.PrintPrize());
                                }
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
            }  
           
        }
    }
}
