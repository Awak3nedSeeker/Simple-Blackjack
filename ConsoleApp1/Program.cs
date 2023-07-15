using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace ConsoleApp1
{
    //card
    //deck
    //game
    //hand
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Deck black = new Deck();
            Cards card = new Cards();
            Console.SetWindowSize(100, 50);
            

            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2);
            Console.WriteLine("Welcome to Blackjack");

            Console.SetCursorPosition(0, Console.WindowHeight);
            Console.Write("Press Enter to continue:");
            Console.ReadLine();
            Console.Clear();
            card.Suf();
            Program program = new Program();
            program.MainMenu();
        }

        public void MainMenu()
        {
            int input;
            Deck black = new Deck();
            Cards card = new Cards();

            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 - 3);                
                Console.WriteLine("   Main Menu");

                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 - 2);
                Console.WriteLine("---------------");

                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 - 1);
                Console.WriteLine("|1. Play Game |");

                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2);
                Console.WriteLine("|2. Show Deck |");

                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 + 1);
                Console.WriteLine("|3. View rules|");

                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 + 2);
                Console.WriteLine("|4. Exit      |");

                Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 + 3);
                Console.WriteLine("---------------");
                
                

                Console.SetCursorPosition(0, Console.WindowHeight);
                Console.Write("Enter an option to continue:");
                input = Utility.ReadInt();

                Console.Clear();

                if (input == 1)
                    card.Game();

                else if (input == 2)
                {
                    black.Draw();

                    Console.Write("Press ENTER to return:");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (input == 3)
                {
                    Console.WriteLine("1. Aces may be counted as 1 or 11 points, 2 to 9 according to pip value, and tens and");
                    Console.WriteLine("   " + "face cards count as ten points.");
                    Console.WriteLine("2. Each participant attempts to beat the dealer by getting a count as close to 21 as");
                    Console.WriteLine("   " + "possible, without going over 21.");
                    Console.WriteLine("3. At the beginning of each round, both the player and the dealer are dealt 2 cards.");
                    Console.WriteLine("4. Calling STAY will end your turn that hand with the sum of cards currently held.");
                    Console.WriteLine("5. Calling HIT will make the dealer give the player an additional card to their hand.");
                    Console.WriteLine("6. Busting means the player or dealer has a sum of more than 21, and will result in a loss");

                    Console.SetCursorPosition(0, Console.WindowHeight - 1);
                    Console.Write("Press ENTER to return:");
                    Console.ReadLine();
                    Console.Clear();
                }
                



            } while (!Utility.IsReadGood() || input < 4 || input > 4);
        }
    }
}
