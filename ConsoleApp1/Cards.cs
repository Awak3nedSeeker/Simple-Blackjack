using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace ConsoleApp1
{
    public class Cards
    {

        public Cards()
        {
        }
        public static int[] spades = new int[13];
        public static int[] hearts = new int[13];
        public static int[] diamonds = new int[13];
        public static int[] clubs = new int[13];
        public static string[] deke = new string[52];
        string[] shuff = new string[52];
        List<string> player = new List<string>();
        List<string> AI = new List<string>();
        string offset = "1. Hit:";
        string newoffset = "2. Stay:";
        int choice;
        int game;
        int playerpoint = 0;
        int dealerpoint = 0;
        int s = 0;
        int h = 0;
        int d = 0;
        int c = 0;
        int Z;


        public void Spades()
        {
            for (int i = 0; i < spades.Length; i++)
            {
                s++;
                spades[i] = s;
            }
            for (int i = 0; i < spades.Length; i++)
            {
                if (spades[i] == 1)
                    Console.WriteLine("A" + " " + "♠");
                else if (spades[i] == 11)
                    Console.WriteLine("J" + " " + "♠");
                else if (spades[i] == 12)
                    Console.WriteLine("Q" + " " + "♠");
                else if (spades[i] == 13)
                    Console.WriteLine("K" + " " + "♠");
                else
                    Console.WriteLine(spades[i] + " " + "♠");
                Console.WriteLine();
            }
        }

        public void Hearts()
        {
            for (int i = 0; i < hearts.Length; i++)
            {
                h++;
                hearts[i] = h;
            }
            for (int i = 0; i < hearts.Length; i++)
            {
                if (hearts[i] == 1)
                    Console.WriteLine("A" + " " + "♥");
                else if (hearts[i] == 11)
                    Console.WriteLine("J" + " " + "♥");
                else if (hearts[i] == 12)
                    Console.WriteLine("Q" + " " + "♥");
                else if (hearts[i] == 13)
                    Console.WriteLine("K" + " " + "♥");
                else
                    Console.WriteLine(hearts[i] + " " + "♥");
                Console.WriteLine();
            }
        }

        public void Diamonds()
        {
            for (int i = 0; i < diamonds.Length; i++)
            {
                d++;
                diamonds[i] = d;
            }
            for (int i = 0; i < diamonds.Length; i++)
            {
                if (diamonds[i] == 1)
                    Console.WriteLine("A" + " " + "♦");
                else if (diamonds[i] == 11)
                    Console.WriteLine("J" + " " + "♦");
                else if (diamonds[i] == 12)
                    Console.WriteLine("Q" + " " + "♦");
                else if (diamonds[i] == 13)
                    Console.WriteLine("K" + " " + "♦");
                else
                    Console.WriteLine(diamonds[i] + " " + "♦");
                Console.WriteLine();
            }
        }

        public void Clubs()
        {
            for (int i = 0; i < clubs.Length; i++)
            {
                c++;
                clubs[i] = c;
            }
            for (int i = 0; i < clubs.Length; i++)
            {
                if (clubs[i] == 1)
                    Console.WriteLine("A" + " " + "♣");
                else if (clubs[i] == 11)
                    Console.WriteLine("J" + " " + "♣");
                else if (clubs[i] == 12)
                    Console.WriteLine("Q" + " " + "♣");
                else if (clubs[i] == 13)
                    Console.WriteLine("K" + " " + "♣");
                else
                    Console.WriteLine(clubs[i] + " " + "♣");
                Console.WriteLine();
            }
        }

        public void Suf()
        {
            Array.Clear(deke, 0, deke.Length);
            for (int suit = 0; suit < 4; suit++)
            {
                h = 0;
                d = 0;
                c = 0;
                s = 0;
                if (suit == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                    for (int i = 0; i < 13; i++)
                    {
                        s++;
                        deke[i] = Convert.ToString(s);
                    }
                    for (int i = 0; i < 13; i++)
                    {
                        if (deke[i] == "1")
                            deke[i] = ("A" + " " + "♠");
                        else if (deke[i] == "11")
                            deke[i] = ("J" + " " + "♠");
                        else if (deke[i] == "12")
                            deke[i] = ("Q" + " " + "♠");
                        else if (deke[i] == "13")
                            deke[i] = ("K" + " " + "♠");
                        else
                            deke[i] = (deke[i] + " " + "♠");
                    }
                }

                if (suit == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 13; i < 26; i++)
                    {
                        h++;
                        deke[i] = Convert.ToString(h);
                    }
                    for (int i = spades.Length; i < 26; i++)
                    {
                        if (deke[i] == "1")
                            deke[i] = ("A" + " " + "♥");
                        else if (deke[i] == "11")
                            deke[i] = ("J" + " " + "♥");
                        else if (deke[i] == "12")
                            deke[i] = ("Q" + " " + "♥");
                        else if (deke[i] == "13")
                            deke[i] = ("K" + " " + "♥");
                        else
                            deke[i] = (deke[i] + " " + "♥");

                    }
                }

                if (suit == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    for (int i = 26; i < 39; i++)
                    {
                        c++;
                        deke[i] = Convert.ToString(c);
                    }
                    for (int i = spades.Length + hearts.Length; i < spades.Length + hearts.Length + clubs.Length; i++)
                    {

                        if (deke[i] == "1")
                            deke[i] = ("A" + " " + "♣");
                        else if (deke[i] == "11")
                            deke[i] = ("J" + " " + "♣");
                        else if (deke[i] == "12")
                            deke[i] = ("Q" + " " + "♣");
                        else if (deke[i] == "13")
                            deke[i] = ("K" + " " + "♣");
                        else
                            deke[i] = (deke[i] + " " + "♣");

                    }
                }

                if (suit == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 39; i < 52; i++)
                    {
                        d++;
                        deke[i] = Convert.ToString(d);
                    }
                    for (int i = spades.Length + hearts.Length + clubs.Length; i < spades.Length + hearts.Length + clubs.Length + diamonds.Length; i++)
                    {
                        if (deke[i] == "1")
                            deke[i] = ("A" + " " + "♦");
                        else if (deke[i] == "11")
                            deke[i] = ("J" + " " + "♦");
                        else if (deke[i] == "12")
                            deke[i] = ("Q" + " " + "♦");
                        else if (deke[i] == "13")
                            deke[i] = ("K" + " " + "♦");
                        else
                            deke[i] = (deke[i] + " " + "♦");

                    }
                }
            }
            Random random = new Random();

            for (int i = 0; i <= 200; i++)
            {

                int number = random.Next(0, 52); //Random number
                int rng = random.Next(0, 52); //Another one

                string swap = deke[number];
                deke[number] = deke[rng];
                deke[rng] = swap;
                //for (int j = 0; j < 52; j++)
                //{
                //    if (shuff.Contains(deke[number])) // NO REPEAT SHUFFLE
                //    {

                //        number = random.Next(0, 51); //AGAIN RANDOM

                //    }
                //    else
                //    {
                //        shuff[i] = deke[number]; //ADD CARD
                //    }
                //}

            }
            //for (int i = 0; i < shuff.Length; i++)
            //{
            //    Console.WriteLine(shuff[i]);
            //}



        }

        public void Print()
        {
            for (int i = 0; i < deke.Length; i++)
            {
                Console.WriteLine(deke[i]);
            }
        }

        public void Game()
        {
            Z = 0;
            int e;
            player.Clear();
            AI.Clear();
            Suf();
            player.Add(Deal());
            player.Add(Deal());
            AI.Add(Deal());
            AI.Add(Deal());
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, Console.WindowHeight - 2);
                Console.Write("Player: ");
                for (int i = 0; i < player.Count; i++)
                {
                    Console.Write(player[i]);
                    Console.Write(" | ");
                }
                Points(player);

                Console.SetCursorPosition(0, 0);
                Console.Write("Dealer: ");
                Console.Write("Facedown");
                for (int i = 0; i < AI.Count - 1; i++)
                {
                    Console.Write(" | ");
                    Console.Write(AI[i]);

                }
                Dealerpoint(AI);
                Console.SetCursorPosition(Console.WindowWidth / 2 - offset.Length / 2, Console.WindowHeight / 2 - 1);
                Console.Write(offset);

                Console.SetCursorPosition(Console.WindowWidth / 2 - newoffset.Length / 2, Console.WindowHeight / 2 + 1);
                Console.Write(newoffset);

                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write("Enter an option to continue:");
                choice = Utility.ReadInt();

                if (choice == 1)
                {
                    player.Add(Deal());
                }
                Points(player);
                e = playerpoint;
                if (e > 21)
                {
                    playerpoint = 0;

                    //Console.SetCursorPosition(0, Console.WindowHeight / 2);
                    //Console.WriteLine("You Lose!!");


                    //Console.SetCursorPosition(0, Console.WindowHeight - 2);
                    //Console.Write("Player: ");
                    //for (int i = 0; i < player.Count; i++)
                    //{
                    //    Console.Write(player[i]);
                    //    Console.Write(" | ");
                    //}
                    //Console.ReadLine();
                    //Console.Clear();
                    //Return();
                }


            } while ((!Utility.IsReadGood() || choice < 2 || choice > 2) &&  e <= 21);
             
            
                while(dealerpoint < 17 && playerpoint != 0)
                {
                    AI.Add(Deal());
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Dealer: ");
                    
                    for (int i = 0; i < AI.Count; i++)
                    {
                        Console.Write(" | ");
                        Console.Write(AI[i]);
                    }
                    Dealerpoint(AI);
                }
                
                Dealerpoint(AI);
                if(dealerpoint > 21)
                {
                    Console.SetCursorPosition(0, Console.WindowHeight / 2);
                    Console.Write("You Win!!");
                }
            
                                   
                else if (dealerpoint == playerpoint)
                {
                    Console.SetCursorPosition(0, Console.WindowHeight / 2);
                    Console.Write("It's a Tie!!");

                }
                else if (dealerpoint > playerpoint)
                {
                    Console.SetCursorPosition(0, Console.WindowHeight / 2);
                    Console.Write("You Lose!!");

                }
                
                Console.ReadLine();
                Console.Clear();

            Return();
            




        }


        public string Deal()
        {
            string deal = deke[Z];
            Z++;
            return deal;

        }

        public void Points(List<string> list)
        {
            playerpoint = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == ("A" + " " + "♠") || list[i] == ("A" + " " + "♥") || list[i] == ("A" + " " + "♦") || list[i] == ("A" + " " + "♣"))
                {
                    playerpoint += 11;
                }

                else if (list[i] == ("2" + " " + "♠") || list[i] == ("2" + " " + "♥") || list[i] == ("2" + " " + "♣") || list[i] == ("2" + " " + "♦"))
                {
                    playerpoint += 2;
                }

                else if (list[i] == ("3" + " " + "♠") || list[i] == ("3" + " " + "♥") || list[i] == ("3" + " " + "♣") || list[i] == ("3" + " " + "♦"))
                {
                    playerpoint += 3;
                }

                else if (list[i] == ("4" + " " + "♠") || list[i] == ("4" + " " + "♥") || list[i] == ("4" + " " + "♣") || list[i] == ("4" + " " + "♦"))
                {
                    playerpoint += 4;
                }

                else if (list[i] == ("5" + " " + "♠") || list[i] == ("5" + " " + "♥") || list[i] == ("5" + " " + "♣") || list[i] == ("5" + " " + "♦"))
                {
                    playerpoint += 5;
                }

                else if (list[i] == ("6" + " " + "♠") || list[i] == ("6" + " " + "♥") || list[i] == ("6" + " " + "♣") || list[i] == ("6" + " " + "♦"))
                {
                    playerpoint += 6;
                }

                else if (list[i] == ("7" + " " + "♠") || list[i] == ("7" + " " + "♥") || list[i] == ("7" + " " + "♣") || list[i] == ("7" + " " + "♦"))
                {
                    playerpoint += 7;
                }

                else if (list[i] == ("8" + " " + "♠") || list[i] == ("8" + " " + "♥") || list[i] == ("8" + " " + "♣") || list[i] == ("8" + " " + "♦"))
                {
                    playerpoint += 8;
                }

                else if (list[i] == ("9" + " " + "♠") || list[i] == ("9" + " " + "♥") || list[i] == ("9" + " " + "♣") || list[i] == ("9" + " " + "♦"))
                {
                    playerpoint += 9;
                }

                else if (list[i] == ("10" + " " + "♠") || list[i] == ("10" + " " + "♥") || list[i] == ("10" + " " + "♣") || list[i] == ("10" + " " + "♦"))
                {
                    playerpoint += 10;
                }

                else if (list[i] == ("J" + " " + "♠") || list[i] == ("J" + " " + "♥") || list[i] == ("J" + " " + "♣") || list[i] == ("J" + " " + "♦"))
                {
                    playerpoint += 10;
                }

                else if (list[i] == ("Q" + " " + "♠") || list[i] == ("Q" + " " + "♥") || list[i] == ("Q" + " " + "♣") || list[i] == ("Q" + " " + "♦"))
                {
                    playerpoint += 10;
                }

                else if (list[i] == ("K" + " " + "♠") || list[i] == ("K" + " " + "♥") || list[i] == ("K" + " " + "♣") || list[i] == ("K" + " " + "♦"))
                {
                    playerpoint += 10;
                }                               
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (playerpoint > 21)
                {
                    if (list[i] == ("A" + " " + "♠") || list[i] == ("A" + " " + "♥") || list[i] == ("A" + " " + "♦") || list[i] == ("A" + " " + "♣"))
                    {
                        playerpoint -= 10;
                    }
                }
                //if(playerpoint > 21)
                //{
                    
                //    //Console.Clear();
                //}
            }
            
            Console.SetCursorPosition(Console.WindowWidth - 3, Console.WindowHeight - 2);
            Console.Write(playerpoint);
            
        }

        public void Dealerpoint(List<string> list)
        {
            dealerpoint = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == ("A" + " " + "♠") || list[i] == ("A" + " " + "♥") || list[i] == ("A" + " " + "♦") || list[i] == ("A" + " " + "♣"))
                {
                    dealerpoint += 11;
                }

                else if (list[i] == ("2" + " " + "♠") || list[i] == ("2" + " " + "♥") || list[i] == ("2" + " " + "♣") || list[i] == ("2" + " " + "♦"))
                {
                    dealerpoint += 2;
                }

                else if (list[i] == ("3" + " " + "♠") || list[i] == ("3" + " " + "♥") || list[i] == ("3" + " " + "♣") || list[i] == ("3" + " " + "♦"))
                {
                    dealerpoint += 3;
                }

                else if (list[i] == ("4" + " " + "♠") || list[i] == ("4" + " " + "♥") || list[i] == ("4" + " " + "♣") || list[i] == ("4" + " " + "♦"))
                {
                    dealerpoint += 4;
                }

                else if (list[i] == ("5" + " " + "♠") || list[i] == ("5" + " " + "♥") || list[i] == ("5" + " " + "♣") || list[i] == ("5" + " " + "♦"))
                {
                    dealerpoint += 5;
                }

                else if (list[i] == ("6" + " " + "♠") || list[i] == ("6" + " " + "♥") || list[i] == ("6" + " " + "♣") || list[i] == ("6" + " " + "♦"))
                {
                    dealerpoint += 6;
                }
                else if (list[i] == ("7" + " " + "♠") || list[i] == ("7" + " " + "♥") || list[i] == ("7" + " " + "♣") || list[i] == ("7" + " " + "♦"))
                {
                    dealerpoint += 7;
                }

                else if (list[i] == ("8" + " " + "♠") || list[i] == ("8" + " " + "♥") || list[i] == ("8" + " " + "♣") || list[i] == ("8" + " " + "♦"))
                {
                    dealerpoint += 8;
                }

                else if (list[i] == ("9" + " " + "♠") || list[i] == ("9" + " " + "♥") || list[i] == ("9" + " " + "♣") || list[i] == ("9" + " " + "♦"))
                {
                    dealerpoint += 9;
                }

                else if (list[i] == ("10" + " " + "♠") || list[i] == ("10" + " " + "♥") || list[i] == ("10" + " " + "♣") || list[i] == ("10" + " " + "♦"))
                {
                    dealerpoint += 10;
                }

                else if (list[i] == ("J" + " " + "♠") || list[i] == ("J" + " " + "♥") || list[i] == ("J" + " " + "♣") || list[i] == ("J" + " " + "♦"))
                {
                    dealerpoint += 10;
                }

                else if (list[i] == ("Q" + " " + "♠") || list[i] == ("Q" + " " + "♥") || list[i] == ("Q" + " " + "♣") || list[i] == ("Q" + " " + "♦"))
                {
                    dealerpoint += 10;
                }

                else if (list[i] == ("K" + " " + "♠") || list[i] == ("K" + " " + "♥") || list[i] == ("K" + " " + "♣") || list[i] == ("K" + " " + "♦"))
                {
                    dealerpoint += 10;
                }              
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (dealerpoint > 21)
                {
                    if (list[i] == ("A" + " " + "♠") || list[i] == ("A" + " " + "♥") || list[i] == ("A" + " " + "♦") || list[i] == ("A" + " " + "♣"))
                    {
                        dealerpoint -= 10;
                    }
                }
                if (dealerpoint > 21)
                {
                    Console.SetCursorPosition(0, Console.WindowHeight / 2);
                    Console.Write("You Win!!");
                }
            }

            Console.SetCursorPosition(Console.WindowWidth - 3, 0);
                Console.Write(dealerpoint);
            
        }

        public void Return()
        {
            do
            {
                Console.SetCursorPosition(0, Console.WindowHeight / 2 - 2);
                Console.WriteLine("What do you want to do?: ");
                Console.WriteLine("1. Play again: ");
                Console.WriteLine("2. Get Out: ");
                Console.Write("Please enter an option: ");
                game = Utility.ReadInt();
                Console.Clear();
                if (game == 1)
                {
                    Game();
                }
                


            } while (!Utility.IsReadGood() || game < 2 || game > 2);
        }
    }
}
