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

        public Status IsBlackJack(int score)
        {
            if (score == 21)
            {
                return Status.BlackJack;
            }

            return Status.Safe;
        }

        public Status IsBust(int score)
        {
            if (score > 21)
            {
                return Status.Bust;
            }

            return Status.Safe;
        }
        //initialise by creating participating and drawing two cards to start
        public void StartGame(Person participant, Deck deck)
        {
            participant.AddToHand(deck.GetCard());
            participant.AddToHand(deck.GetCard());
            participant.GetCurrentScore();
            
            // print method needed
        }
        //each round = draw, calculate score, adjust score if needed, and check status print and ask for input

        public void GameContinue()
        {
            
        }
        
    }
}