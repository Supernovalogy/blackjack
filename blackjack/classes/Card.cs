using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack.classes
{
    public class Card : Deck
    {
        public string Suit { get; set; }
        public int ActualValue { get; set; }
        public string FaceValue { get; set; }
    }
}
