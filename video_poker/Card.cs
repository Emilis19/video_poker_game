using System;
using System.Collections.Generic;
using System.Text;

namespace video_poker
{
    class Card
    {
        public enum SUIT
        {
            hearts,
            diamonds,
            spades,
            clubs
        }
        public enum VALUE
        {
            two,
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
        public SUIT Suit { get; set; }
        public VALUE Value { get; set; }

    }
}
