using System;

namespace video_poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Video poker game");
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
            }
        }
    }
}
