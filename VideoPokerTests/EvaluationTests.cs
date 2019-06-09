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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsRoyalFlush(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsRoyalFlush(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsStraightFlush(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsStraightFlush(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsStraight(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsStraight(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsFlush(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsFlush(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsTwoPair(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsTwoPair(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsTwoPair(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsThreeOfAKind(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsThreeOfAKind(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsFullHouse(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsFullHouse(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsFourOfAKind(hand);
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
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsFourOfAKind(hand);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void JacksOrBetter()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.five));
            hand.Add(new Card(Suit.spades, Value.queen));
            hand.Add(new Card(Suit.clubs, Value.jack));
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsJacksOrBetter(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void JacksOrBetter2()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.spades, Value.jack));
            hand.Add(new Card(Suit.hearts, Value.two));
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsJacksOrBetter(hand);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void JacksOrBetterFalse()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.clubs, Value.three));
            hand.Add(new Card(Suit.hearts, Value.queen));
            hand.Add(new Card(Suit.spades, Value.king));
            hand.Add(new Card(Suit.hearts, Value.two));
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsJacksOrBetter(hand);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TwoPairString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.spades, Value.queen));
            hand.Add(new Card(Suit.clubs, Value.jack));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have two pairs! Prize: 2", actual);
        }
        [TestMethod]
        public void JacksOrBetterFalse3()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.clubs, Value.three));
            hand.Add(new Card(Suit.hearts, Value.four));
            hand.Add(new Card(Suit.spades, Value.four));
            hand.Add(new Card(Suit.hearts, Value.two));
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsJacksOrBetter(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void JacksOrBetterFalse4()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.clubs, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.jack));
            hand.Add(new Card(Suit.spades, Value.jack));
            hand.Add(new Card(Suit.hearts, Value.two));
            Evaluation evaluation = new Evaluation();
            bool actual = evaluation.IsJacksOrBetter(hand);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void ThreePairString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.spades, Value.three));
            hand.Add(new Card(Suit.clubs, Value.jack));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have a three of a kind! Prize: 3", actual);
        }
        [TestMethod]
        public void FourPairString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.spades, Value.three));
            hand.Add(new Card(Suit.clubs, Value.three));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have a four of a kind! Prize: 25", actual);
        }
        [TestMethod]
        public void FullHouseString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.three));
            hand.Add(new Card(Suit.spades, Value.three));
            hand.Add(new Card(Suit.spades, Value.queen));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have a full house! Prize: 9", actual);

        }
        [TestMethod]
        public void StraightString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.four));
            hand.Add(new Card(Suit.hearts, Value.six));
            hand.Add(new Card(Suit.spades, Value.five));
            hand.Add(new Card(Suit.spades, Value.seven));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have a straight! Prize: 4", actual);

        }
        [TestMethod]
        public void FlushString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.seven));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.diamonds, Value.two));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have a flush! Prize: 6", actual);

        }
        [TestMethod]
        public void StraightFlushString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.diamonds, Value.five));
            hand.Add(new Card(Suit.diamonds, Value.four));
            hand.Add(new Card(Suit.diamonds, Value.seven));
            hand.Add(new Card(Suit.diamonds, Value.six));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have a straight flush! Prize: 50", actual);

        }
        [TestMethod]
        public void RoyalFlushString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.ace));
            hand.Add(new Card(Suit.diamonds, Value.queen));
            hand.Add(new Card(Suit.diamonds, Value.ten));
            hand.Add(new Card(Suit.diamonds, Value.king));
            hand.Add(new Card(Suit.diamonds, Value.jack));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have a royal flush! Prize: 800", actual);

        }
        [TestMethod]
        public void JacksString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.king));
            hand.Add(new Card(Suit.clubs, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.two));
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.clubs, Value.queen));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("You have jacks or better! Prize: 1", actual);

        }
        [TestMethod]
        public void NothingString()
        {
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.diamonds, Value.king));
            hand.Add(new Card(Suit.clubs, Value.queen));
            hand.Add(new Card(Suit.hearts, Value.two));
            hand.Add(new Card(Suit.diamonds, Value.three));
            hand.Add(new Card(Suit.clubs, Value.five));
            Evaluation evaluation = new Evaluation();
            var actual = evaluation.Evaluate(hand);
            Assert.AreEqual("Sorry but you have nothing. Prize: 0", actual);

        }
    }
}
