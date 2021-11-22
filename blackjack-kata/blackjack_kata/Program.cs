using System;

namespace blackjack_kata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Deck newDeck = new Deck();
            newDeck.CreateDeck();
            newDeck.RandomiseDeck();
            for (int i = 0; i < 52; i++)
            {
                newDeck.GetCard().Printcard();
            }
        }
    }
}