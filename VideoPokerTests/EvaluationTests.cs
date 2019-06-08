using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using video_poker;

namespace VideoPokerTests
{
    [TestClass]
    public class EvaluationTests
    {
        [TestMethod]
        public void RoyalFlush()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.ten));
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.diamonds, Value.king));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            bool actual = Evaluation.IsRoyalFlush(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void RoyalFlushFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.spades, Value.ten));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.clubs, Value.king));
            hand.Add(new Card(Suit.diamonds, Value.ace));
            bool actual = Evaluation.IsRoyalFlush(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void StraightFlush()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.two));
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.four));
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.six));
            bool actual = Evaluation.IsStraightFlush(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void StraightFlushFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.two));
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.clubs, Value.four));
            hand.Add(new Card(Suit.hearts, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.six));
            bool actual = Evaluation.IsStraightFlush(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void Straight()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.hearts, Value.king));
            hand.Add(new Card(Suit.hearts, Value.queen));
            hand.Add(new Card(Suit.clubs, Value.ten));
            hand.Add(new Card(Suit.spades, Value.jack));
            bool actual = Evaluation.IsStraight(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void StraightFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.hearts, Value.two));
            hand.Add(new Card(Suit.hearts, Value.queen));
            hand.Add(new Card(Suit.clubs, Value.ten));
            hand.Add(new Card(Suit.spades, Value.jack));
            bool actual = Evaluation.IsStraight(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void Flush()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.two));
            hand.Add(new Card(Suit.diamonds, Value.ten));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.ace));
            bool actual = Evaluation.IsFlush(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void FlushFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.two));
            hand.Add(new Card(Suit.clubs, Value.ten));
            hand.Add(new Card(Suit.hearts, Value.jack));
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.ace));
            bool actual = Evaluation.IsFlush(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void TwoPair()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.hearts, Value.ace));
            hand.Add(new Card(Suit.clubs, Value.three));
            hand.Add(new Card(Suit.clubs, Value.five));
            hand.Add(new Card(Suit.spades, Value.three));
            bool actual = Evaluation.IsTwoPair(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void TwoPairFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.hearts, Value.ace));
            hand.Add(new Card(Suit.clubs, Value.ace));
            hand.Add(new Card(Suit.clubs, Value.five));
            hand.Add(new Card(Suit.spades, Value.three));
            bool actual = Evaluation.IsTwoPair(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void TwoPairHighCards()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.hearts, Value.ace));
            hand.Add(new Card(Suit.clubs, Value.king));
            hand.Add(new Card(Suit.clubs, Value.five));
            hand.Add(new Card(Suit.spades, Value.king));
            bool actual = Evaluation.IsTwoPair(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void ThreeOfAKind()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.clubs, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            bool actual = Evaluation.IsThreeOfAKind(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void ThreeOfAKindFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.clubs, Value.five));
            hand.Add(new Card(Suit.spades, Value.five));
            hand.Add(new Card(Suit.hearts, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            bool actual = Evaluation.IsThreeOfAKind(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void FullHouse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.clubs, Value.five));
            hand.Add(new Card(Suit.hearts, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.ten));
            hand.Add(new Card(Suit.hearts, Value.ten));
            bool actual = Evaluation.IsFullHouse(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void FullHouseFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.clubs, Value.five));
            hand.Add(new Card(Suit.hearts, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.seven));
            hand.Add(new Card(Suit.hearts, Value.ten));
            bool actual = Evaluation.IsFullHouse(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void FourOfAKind()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.spades, Value.three));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.clubs, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            bool actual = Evaluation.IsFourOfAKind(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void FourOfAKindFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.spades, Value.seven));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.clubs, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            bool actual = Evaluation.IsFourOfAKind(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void JacksOrBetterFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.queen));
            hand.Add(new Card(Suit.spades, Value.king));
            hand.Add(new Card(Suit.clubs, Value.king));
            bool actual = Evaluation.IsJacksOrBetter(hand);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void JacksOrBetter()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.spades, Value.queen));
            hand.Add(new Card(Suit.clubs, Value.jack));
            bool actual = Evaluation.IsJacksOrBetter(hand);
            Assert.AreEqual(true, actual);
        }
    }
}
