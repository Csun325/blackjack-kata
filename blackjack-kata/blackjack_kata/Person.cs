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
        public Choice Action;
        public Conclusion Outcome;
        
        public enum Choice
        {
            Hit, 
            Stay
        }
        public enum Conclusion
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
                if (c.GetRankValue() == 0)
                {
                    aceNums++;
                }
                this.AceNum = aceNums;
                score += c.GetRankValue();
            }

            //this.AceNum = aceNums;
            this.Score = score;
            
            return score;
        }
        
        public void AddToHand(Card card)
        {
            Hand.Add(card);
        }

        public virtual void AskInput()
        {
        }
        
        
        public virtual void PrintCurrentHand(int score, Game.Status status)
        {
        }
    }
}