using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack_kata
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public Stack<Card> mixedCards = null!;
        static Random rnd = new Random();

        // Creating a deck of 52 cards
        public void CreateDeck()
        {
            foreach (Card.Suit suits in Enum.GetValues(typeof(Card.Suit)))
            {
                for (int i = 2; i < 11; i++)
                {
                    Card.Rank k = (Card.Rank) i;
                    Card cd = new Card(k, suits);
                    cards.Add(cd);
                }
    
                cards.Add(new Card(Card.Rank.Ace, suits));
                cards.Add(new Card(Card.Rank.King, suits));
                cards.Add(new Card(Card.Rank.Queen, suits));
                cards.Add(new Card(Card.Rank.Jack, suits));
                
                
            }
            
            
        }

        // randomised the deck of cards into mixed cards
        public void RandomiseDeck()
        {
            //var rnd = new Random();
            // mixedCards = new Stack<Card>(cards.OrderBy(item => rnd.Next()));
            Console.WriteLine(cards.Count);
            
            for (int i = cards.Count - 1; i > 0; --i)
            {
                int k = rnd.Next(i + 1);
                (cards[i], cards[k]) = (cards[k], cards[i]);
            }

            mixedCards = new Stack<Card>(cards);
        }

        public Card GetCard()
        {
            return mixedCards.Pop();
        }
        
    }
}