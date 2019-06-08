using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace video_poker
{
    public static class Evaluation
    {
        public static string Evaluate(List<Card> hand)
        {
            if (IsFlush(hand))
            {
                if (IsStraight(hand))
                {
                    if (IsRoyalFlush(hand))
                    {
                        return "You have a royal flush! Prize: 800";
                    }
                    return "You have a straight flush! Prize: 50";
                }
                return "You have a flush! Prize: 6";
            }

            if (IsStraight(hand))
                return "You have a straight! Prize: 4";

            if (IsFourOfAKind(hand))
                    return "You have a four of a kind! Prize: 25";

                if (IsFullHouse(hand))
                    return "You have a full house! Prize: 9";

                if (IsThreeOfAKind(hand))
                    return "You have a three of a kind! Prize: 3";

                if (IsTwoPair(hand))
                    return "You have two pairs! Prize: 2";

                if (IsJacksOrBetter(hand))
                    return "You have jacks or better! Prize: 1";

                return "Sorry but you have nothing. Prize: 0";

        }


        public static bool IsFlush(List<Card> hand)
        {
            return hand.GroupBy(h => h.Suit).Count() == 1;
        }


        public static bool IsStraight(List<Card> hand)
        {
            var ordered = hand.OrderBy(h => h.Value).ToArray();
            for (int i = 1; i < ordered.Length; i++)
            {
                if ((int)ordered[i - 1].Value + 1 != (int)ordered[i].Value)
                    return false;
            }
            return true;
        }

        public static bool IsStraightFlush(List<Card> hand)
        {
            return IsStraight(hand) && IsFlush(hand);
        }

        public static bool IsRoyalFlush(List<Card> hand)
        {
            var ordered = hand.OrderBy(h => h.Value).ToArray();
            return IsStraightFlush(hand) && ordered[0].Value.Equals(Value.ten) && ordered[4].Value.Equals(Value.ace);
        }

        public static bool IsPair(List<Card> hand)
        {
            return hand.GroupBy(h => h.Value).Where(g => g.Count() == 2).Count() == 1;
        }

        public static bool IsTwoPair(List<Card> hand)
        {
                return hand.GroupBy(h => h.Value).Where(g => g.Count() == 2).Count() == 2;
        }

        public static bool IsThreeOfAKind(List<Card> hand)
        {
            return hand.GroupBy(h => h.Value).Where(g => g.Count() == 3).Any();
        }

        public static bool IsFourOfAKind(List<Card> hand)
        {
            return hand.GroupBy(h => h.Value).Where(g => g.Count() == 4).Any();
        }
        public static bool IsFullHouse(List<Card> hand)
        {
           // return IsThreeOfAKind(hand) && IsPair(hand);

            int count1 = hand.GroupBy(h => h.Value).ToList()[0].Count();
            int count2 = hand.GroupBy(h => h.Value).ToList()[1].Count();
            return (count1 == 3 && count2 == 2) || (count1 == 2 && count2 == 3);
        }

        public static bool IsJacksOrBetter(List<Card> hand)
        {
            //group by value and check if the key value is greater than 10 (ten = 10 in enum) then check if there is only one pair of those values
          return hand.GroupBy(h => h.Value).Where(h => (int)h.Key > 10).Where(g => g.Count() == 2).Count() == 1;          
        }
    }
}
