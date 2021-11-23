using System;
using System.Linq;

namespace blackjack_kata
{
    public class Player : Person
    {
        
        public override void AskInput()
        {
            Console.Write("\nHit or stay? (Hit = 1, Stay = 0): ");
            var response = int.Parse(Console.ReadLine());
            //! NEED TRY CATCH EXCEPTION
            if (response == 1)
            {
                this.Action = Choice.Hit;
            }
            else
            {
                this.Action = Choice.Stay;
            }
        }


        public override void PrintCurrentHand(int score, Game.Status status)
        {
            switch (status)
            {
                case Game.Status.Bust:
                    Console.WriteLine("You are currently at: Bust!");
                    break;
                case Game.Status.BlackJack:
                    Console.WriteLine("You are currently at: BLACKJACK!" );
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