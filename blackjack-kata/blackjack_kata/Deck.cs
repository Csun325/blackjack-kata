using System;
using System.Collections.Generic;

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
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    
                    Card cd = new Card(rank, suits);
                    cards.Add(cd);
                }
            }
        }
        
        public void RandomiseDeck()
        {
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