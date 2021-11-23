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
            playingDeck.RandomiseDeck();
            
            
            //starting the game for p1
            
            gamelogic.StartGame(p1, playingDeck);
            

            


        }
    }
}