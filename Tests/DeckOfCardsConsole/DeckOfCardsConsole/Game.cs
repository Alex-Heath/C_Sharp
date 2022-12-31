using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsConsole
{
    class Game
    {
        public static void PlayGame(int NumberOfCards, int NumberOfSuits)
        {
            List<PlayingCard> PlayingDeck = Deck.Load(NumberOfSuits);
            Deck.Shuffle(PlayingDeck);
            Deck.Deal(NumberOfCards, PlayingDeck);

        }

        public static int OnlyAcceptNumber(string InputStr)
        {
            string OutputStr = "";
            //OutputStr = "";
            while (!OutputStr.All(char.IsDigit) || OutputStr.Equals(""))
            {
                Console.WriteLine(InputStr);
                OutputStr = Console.ReadLine();
            }
            return int.Parse(OutputStr);
        }
        public static void Menu()
        {
            
            int NumberOfSuits = OnlyAcceptNumber("How many suits do you want to have to work through? (4 suits is one deck)");


            
            int NumberOfCards = OnlyAcceptNumber("How many cards do you want dealt per round?");


            PlayGame(NumberOfCards, NumberOfSuits);

            Console.WriteLine("Time to play again");
          Console.WriteLine("-----------------------------------------");
            Menu();
        }

    }
}

