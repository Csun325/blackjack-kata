using System;
using System.Collections.Generic;

namespace blackjack_kata
{
    public class Card
    {
        private Rank rank;
        private Suit suit;

        public Card(Rank number, Suit suit)
        {
            this.rank = number;
            this.suit = suit;
        }

        public Rank GetRank()
        {
            return this.rank;
        }
        
        // enums of suits and rank
        public enum Suit
        {
            Hearts,
            Spades,
            Diamond,
            Clubs
        }

        public enum Rank
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
            
        }

        public void Printcard()
        {
            Console.WriteLine(rank + " of " + suit);
        }
    }
}