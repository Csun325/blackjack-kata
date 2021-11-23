using System;
using System.Linq;

namespace blackjack_kata
{
    public class Dealer : Person
    {

        // dealer stays after 17
        public override void AskInput()
        {
            var currentScore = this.Score;
            this.Action = currentScore <= 17 ? Choice.Hit : Choice.Stay;
        }

        public override void PrintCurrentHand(int score, Game.Status status)
        {
            switch (status)
            {
                case Game.Status.Bust:
                    Console.WriteLine("Dealer is at: Bust!");
                    break;
                case Game.Status.BlackJack:
                    Console.WriteLine("Dealer is at: BLACKJACK!" );
                    break;
                default:
                    Console.WriteLine("Dealer is at: " + score);
                    break;
            }
            var cards = Hand.Select(c => c.PrintString()).ToList();
            Console.Write("with the hand: ");
            Console.WriteLine(string.Join(",", cards));
        }
        
    }
}