using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    public class Deck
    {
        
        public Deck()
        { 
        }
        Cards dek = new Cards();
        public void Draw()
        {
           
            //Console.ForegroundColor = ConsoleColor.Black;
            //dek.Spades();

            //Console.ForegroundColor = ConsoleColor.Red;
            //dek.Hearts();

            //Console.ForegroundColor = ConsoleColor.Black;
            //dek.Clubs();

            //Console.ForegroundColor = ConsoleColor.Red;
            //dek.Diamonds();
            
            dek.Suf();
            dek.Print();
        }

        public void Points()
        {
            
        }
        
    }
}