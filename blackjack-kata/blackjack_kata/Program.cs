using System;
using System.Collections.Generic;

namespace blackjack_kata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var playingDeck = new Deck();
            var gamelogic = new Game();
            var p1 = new Player();
            var p2 = new Dealer();
            
            
            playingDeck.CreateDeck();
            Console.WriteLine(playingDeck.cards.Count);
            for (int i = 0; i < 52; i++)
            {
                
                playingDeck.cards[i].Printcard();
            }
            
            playingDeck.RandomiseDeck();
            
            
            //starting the game for p1
            
            gamelogic.StartGame(p1, playingDeck);

            Console.WriteLine("Below is what I got");
            p1.Hand[0].Printcard();
            p1.Hand[1].Printcard();
            p1.PrintCurrentHand(p1.Score);

            


        }
    }
}