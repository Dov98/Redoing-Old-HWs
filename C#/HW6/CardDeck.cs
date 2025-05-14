using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace HW6
{
    internal class CardDeck

    //make 2 arrays, the ranks and the suites. and then add them together.
    //tell a person to pick a card
    //ask them if they want to pcik another
    {
        static void Main(string[] args)
        {
            bool pick = true;

            string[] rank = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suite =  { "Hearts", "Clubs", "Diamonds", "Spades" };

            //prints all the cards in a deck
            for (int i = 0; i < suite.Length; i++)
            {

                for (int j = 0; j < rank.Length; j++)
                {
                    Console.Write(rank[j]);
                    Console.Write(" of ");
                    Console.WriteLine(suite[i]);
                }
            }

            Console.WriteLine("Now you see that all the cards are in order.");
            Console.WriteLine("Pick a card, any card.\n");

            //a loop whre you can pick a random card multiple times
            while (pick == true)
            {

            Console.Write("You picked a: ");

            Random rand = new Random();
                

                Console.Write(rank[rand.Next(0,13)]);
                Console.Write(" of ");
                Console.WriteLine(suite[rand.Next(0,4)]);

                Console.WriteLine("Do you want to pick again?\nEnter yes or no.");
                if(Console.ReadLine() == "yes")
                {
                    pick = true;
                }
                else
                {
                    pick = false;
                }

            }
        }
        

    }
}
