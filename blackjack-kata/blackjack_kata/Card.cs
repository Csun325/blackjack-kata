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

        public int GetRankValue()
        {
            return (int) this.rank;
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
            Ace = 11,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 10,
            Queen = 10,
            King = 10
            
        }

        public void AllRanks()
        {
            
        }

        public String PrintString()
        {
            return ("[" + rank.ToString() + " " + suit.ToString() + "]");
        }

        // used for terminal purpose only ... will remove at end
        public void Printcard()
        {
            Console.WriteLine(rank + " of " + suit);
        }
    }
}