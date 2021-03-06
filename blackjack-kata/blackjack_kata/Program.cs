using System;
using System.Collections.Generic;

namespace blackjack_kata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! This is BLACKJACK!\n");
            var playingDeck = new Deck();
            var gameLogic = new Game();
            var p1 = new Player();
            var p2 = new Dealer();
            
            
            playingDeck.CreateDeck();
            playingDeck.RandomiseDeck();
            
            
            
            gameLogic.StartGame(p1, playingDeck);
            gameLogic.GameContinue(p1,playingDeck);

            if (p1.Outcome != Person.Conclusion.Lose)
            {
                Console.WriteLine("\nDealer now Playing");

                gameLogic.StartGame(p2, playingDeck);
                gameLogic.GameContinue(p2, playingDeck);
            }
            else
            {
                Console.WriteLine("\nDealer wins");
            }
            
            //check winning conditions
            gameLogic.CheckWinConditions(p1, p2);

        }
      
    }
}