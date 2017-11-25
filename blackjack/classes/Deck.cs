using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack.classes
{
    public class Deck
    {


        public List<Card> GetDeck()
        {
            string[] faceValues = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = new string[] { "Heart", "Diamond", "Spade", "Club" };
            List<Card> deck = new List<Card>();

            int n = 0;
            int s = 0;
            while (s < 4)
            {
                while (n < 13)
                {
                    Card card = new Card();
                    card.Suit = suits[s];
                    card.IsAce = false;
                    card.FaceValue = faceValues[n];
                    // Assign the ActualValue depending on the FaceValue
                    if (card.FaceValue == "J" | card.FaceValue == "Q" | card.FaceValue == "K")
                    {
                        card.ActualValue = 10;
                    }
                    else if (card.FaceValue == "A")
                    {
                        card.ActualValue = 11;
                        card.IsAce = true;
                    }
                    else
                    {
                        string faceValueString = faceValues[n];
                        int faceValueInt = int.Parse(faceValueString);
                        card.ActualValue = faceValueInt;
                    }
                    n++;

                    deck.Add(card);

                }
                n = 0;
                s++;
            }

            return deck;
        }
    }
}
