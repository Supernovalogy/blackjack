using System;
using blackjack.classes;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck playingDeck = new Deck();
            playingDeck.GetDeck();
        }
    }
}
