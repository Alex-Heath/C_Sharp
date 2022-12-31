using DeckOfCardsConsole.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// just the methods for the deck
namespace DeckOfCardsConsole
{
    public class Deck
    {
        
        public static void Shuffle(List<PlayingCard> freshDeck)
        {
            //PlayingCard[] shuffledDeck = new PlayingCard[] { };
            var rnd = new Random();

            List<PlayingCard> shuffledDeck = freshDeck;
            int n = freshDeck.Count;

            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                PlayingCard value = freshDeck[k];
                freshDeck[k] = freshDeck[n];
                freshDeck[n] = value;
            }

           
        }
        public static List<PlayingCard> Load(int SuitCount)
        {
            List<String> Suits = new List<String> { "Clubs", "Spades", "Diamonds", "Hearts"};
            var ctx = new ApplicationDbContext();
            List<PlayingCard> returnDeck = new List<PlayingCard>();
            for (int i = 0; i < SuitCount; i++)
            {
                string thisSuit = Suits[i % 4];
                returnDeck.AddRange(ctx.PlayingCards.Where(s => s.Suit == thisSuit).ToList());
            }

            return returnDeck;

        }

        public static void Deal(int CardsPerRound, List<PlayingCard> DeckOfCards)
        {
            string LineBreak = "-----------------------------------------\n";
                var ListOfCards = "\n";
                var TotalRoundValue = 0;
                StringBuilder sb = new StringBuilder("\n");
            
            for(int card = 0; card < DeckOfCards.Count; card++)
            {
                        sb.Append(DeckOfCards[card].Name + '\n');
                        TotalRoundValue += DeckOfCards[card].Value;


        
                if(((card+1) % CardsPerRound == 0 && card != 0) || DeckOfCards.Count == card + 1)
                {
                    ListOfCards = sb.ToString();
                    Console.WriteLine("{1}These are the cards you have dealt:{0}{1}Do {2} push ups\n{1}", ListOfCards, LineBreak, TotalRoundValue);
                    var x = Console.ReadLine();

                    ListOfCards = "\n";
                    TotalRoundValue = 0;
                    sb.Clear();
                    sb.Append("\n");
                }

            }
                


        }

    }
}
