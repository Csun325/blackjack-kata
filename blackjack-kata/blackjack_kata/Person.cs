using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace blackjack_kata
{
    public abstract class Person
    {
        public List<Card> Hand = new List<Card>();
        public int Score;
        public int AceNum;
        
        public enum Choice
        {
            Hit, 
            Stay
        }
        protected enum Conclusion
        {
            Win,
            Lose,
            Tie
        }
        
        public int GetCurrentScore()
        {
            var score = 0;
            var aceNums = 0;

            foreach (var c in this.Hand)
            {
                if (c.GetRankValue() == 11) ;
                {
                    aceNums++;
                }
                
                score += c.GetRankValue();
            }

            this.AceNum = aceNums;
            this.Score = score;
            
            return score;
        }
        
        public void AddToHand(Card card)
        {
            Hand.Add(card);
        }

        public Choice AskInput()
        {
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0): ");
            var response = Console.Read();
            //! NEED TRY CATCH EXCEPTION
            if (response == 1)
            {
                return Choice.Hit;
            }

            return Choice.Stay;
        }
        
        
        public void PrintCurrentHand(int score)
        {
            Console.WriteLine("You are currently at: " + score);
            int numCards = Hand.Count;
            var cards = new List<String>();
            foreach (var c in Hand)
            {
                cards.Add(c.PrintString());
            }
            Console.Write("with the hand: ");
            Console.WriteLine(string.Join(",", cards));

        }
    }
}