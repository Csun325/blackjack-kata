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
            Console.Write("Hit or stay? (Hit = 1, Stay = 0): ");
            var response = Console.Read();
            //! NEED TRY CATCH EXCEPTION
            if (response == 1)
            {
                return Choice.Hit;
            }

            return Choice.Stay;
        }
        
        
        public void PrintCurrentHand(int score, Game.Status status)
        {
            switch (status)
            {
                case Game.Status.Bust:
                    Console.WriteLine("You are currently at: Bust!");
                    // set game as lost
                    
                    
                    break;
                case Game.Status.BlackJack:
                    Console.WriteLine("You are currently at: BLACKJACK!" );
                    // record this to the participant instant
                    
                    
                    break;
                default:
                    Console.WriteLine("You are currently at: " + score);
                    break;
            }
            var cards = Hand.Select(c => c.PrintString()).ToList();
            Console.Write("with the hand: ");
            Console.WriteLine(string.Join(",", cards));

        }
    }
}