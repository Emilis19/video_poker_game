using System;
using System.Collections.Generic;
using System.Text;

namespace video_poker
{
    public static class Deck
    {
        public static List<Card> CreateDeck()
        {
            List<Card> deck = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    deck.Add(new Card(suit, value));
                }
            }
            return deck;
        }
    }
}
