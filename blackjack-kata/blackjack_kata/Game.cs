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
                if (s == Status.Bust || s == Status.BlackJack)
                {
                    break;
                }
                participant.AskInput();
            }
        }
    }
}