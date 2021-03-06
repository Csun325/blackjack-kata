using System;
namespace blackjack_kata
{
    public class Game
    {
        // checks if bust, blackjack or still safe
        public enum Status
        {
            Bust,
            BlackJack,
            Safe
        }
        
        public int AdjustAce(int score, int aceNum)
        {
            if (aceNum > 0)
            {
                score -= 10;
                aceNum--;
                AdjustAce(score, aceNum);
            }

            return score;

        }

        public Status CheckStatus(int score)
        {
            return score switch
            {
                21 => Status.BlackJack,
                > 21 => Status.Bust,
                _ => Status.Safe
            };
        }
        
        //initialise by creating participating and drawing two cards to start
        public void StartGame(Person participant, Deck deck)
        {
            participant.AddToHand(deck.GetCard());
            participant.AddToHand(deck.GetCard());
            participant.GetCurrentScore();
            
            Status s = CheckStatus(participant.Score);
            participant.PrintCurrentHand(participant.Score, s);
            
        }
        

        // game continues if action is hit!
        public void GameContinue(Person participant, Deck deck)
        {
            participant.AskInput();
            while (participant.Action == Person.Choice.Hit)
            {
                participant.AddToHand(deck.GetCard());
                participant.GetCurrentScore();

                if (participant.Score > 21)
                {
                    AdjustAce(participant.Score, participant.AceNum); 
                }

                var s = CheckStatus(participant.Score);
                participant.PrintCurrentHand(participant.Score, s);
                if (s == Status.Bust )
                {
                    participant.Outcome = Person.Conclusion.Lose;
                    break;
                }
                if (s == Status.BlackJack)
                {
                    participant.Outcome = Person.Conclusion.Win;
                    break;
                }
                participant.AskInput();
            }
        }


        public void CheckWinConditions(Player p1, Dealer p2)
        {
            if (p2.Score > p1.Score)
            {
                Console.WriteLine("Dealer wins");
            }

            if (p2.Score == p1.Score)
            {
                Console.WriteLine("It's a Tie");
            }

            if (p2.Outcome == Person.Conclusion.Lose)
            {
                Console.WriteLine("You beat the dealer!");
            }
        }
    }
}