using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsConsole
{
    public class PlayingCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value { get; set; }

        public int IsSpecial { get; set; }

        public PlayingCard(int id, string name, string suit, string face, int value, int isSpecial = 0)
        {
            Id = id;
            Name = name;
            Suit = suit;
            Face = face;
            Value = value;
            IsSpecial = isSpecial;
        }
    }
}
