using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace video_poker
{
    public class Logic
    {
        public List<Card> deck { get; private set; }
        public List<Card> hand { get; private set; } = new List<Card>();

        private Random random = new Random();


        public Logic()
        {
            deck = Deck.CreateDeck();          
        }

     /*   public void Shuffle()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                int j = random.Next(52);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
*/
        public void DealFirstHand()
        {
            //  Shuffle();
            Card tempCard = null;
            for (int i = 0; i < 5; i++)
            {
                tempCard = deck[random.Next(0, deck.Count)];
                hand.Add(tempCard);
                deck.Remove(tempCard);
            }
            PrintHand();
        }
        public void ReplaceCards(List<int> indexes)
        {
            Card tempCard = null;
            for(int i = 0; i < indexes.Count; i++)
            {
                tempCard = deck[random.Next(0, deck.Count)];
                hand[indexes[i]] = tempCard;
                deck.Remove(tempCard);
            }
        }
        public void PrintHand()
        {
            Console.WriteLine("Your cards are:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " " + hand[i].Suit + " " + hand[i].Value);
            }
        }
        /*  public void PrintAll()
          {
              int i = 0;
              foreach (var card in deck)
              {
                  Console.WriteLine(i + " " + card.Suit + " " + card.Value);
                      i++;
              }
          }
          */
        public String PrintPrize()
        {
            return Evaluation.Evaluate(hand);
        }
    }
}