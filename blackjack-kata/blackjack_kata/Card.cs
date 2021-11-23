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
            var result = 0;
            switch (this.rank)
            {
                case Rank.Queen:
                case Rank.King:
                case Rank.Jack:
                    result = 10;
                    break;
                case Rank.Ace:
                    result = 11;
                    break;
                default:
                    result = (int) this.rank + 1;
                    break;
            }

            return result;
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

        public void AllRanks()
        {
            
        }

        public String PrintString()
        {
            return ("[" + rank.ToString() + " " + suit.ToString() + "]");
        }
        
    }
}