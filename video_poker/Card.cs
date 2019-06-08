using System;
using System.Collections.Generic;
using System.Text;

    public enum Suit
    {
        hearts,
        diamonds,
        spades,
        clubs
    }
    public enum Value
    {
        two = 2,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace
    }

namespace video_poker
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
