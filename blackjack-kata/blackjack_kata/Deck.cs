using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack_kata
{
    public class Deck
    {
        public Stack<Card> cards = new Stack<Card>();
        public Stack<Card> mixedCards = null!;

        // Created a deck of 52 cards
        public void CreateDeck()
        {
            foreach (Card.Suit suits in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                     // create card and add to stack
                     Card cd = new Card(rank, suits);
                     cards.Push(cd);
                     // check via terminal
                     //cd.Printcard();
                }
            }
        }

        // randomised the deck of cards into mixed cards
        public void RandomiseDeck()
        {
            var rnd = new Random();
            mixedCards = new Stack<Card>(cards.OrderBy(item => rnd.Next()));
        }

        public Card GetCard()
        {
            return mixedCards.Pop();
        }
        
    }
}