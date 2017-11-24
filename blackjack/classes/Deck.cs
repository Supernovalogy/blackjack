using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack.classes
{
    public class Deck
    {
        List<Card> playingDeck = new List<Card>();


        // faceValues to be used when creating Card instances
        string[] faceValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        private List<Card> GetHearts()
        {
            // create a copy of faceValues so we don't mess up the original faceValues later on
            string[] heartFaceValues = new string[faceValues.Length];

            Array.Copy(faceValues, heartFaceValues, faceValues.Length);

            List<Card> hearts = new List<Card>();

            // create individual heart cards then add them to the hearts list
            int n = 0;
            while (n < 13)
            {
                Card card = new Card();
                card.Suit = "Heart";
                // Assign the ActualValue depending on the FaceValue
                if (card.faceValues[n] == "J" | card.faceValues[n] == "Q" | card.faceValues[n] == "K")
                {
                    card.ActualValue = 10;
                }
                else if (card.faceValues[n] == "A")
                {
                    card.ActualValue = 11;
                }
                else
                {
                    string faceValueString = faceValues[n];
                    int faceValueInt = int.Parse(faceValueString);
                    card.ActualValue = faceValueInt;
                }
                card.FaceValue = faceValues[n];
                n++;

                hearts.Add(card);
                
            }

            return hearts;
        }

        private List<Card> GetDiamonds()
        {
            // create a copy of faceValues so we don't mess up the original faceValues later on
            string[] diamondFaceValues = new string[faceValues.Length];

            Array.Copy(faceValues, diamondFaceValues, faceValues.Length);

            List<Card> diamonds = new List<Card>();

            // create individual heart cards then add them to the hearts list
            int n = 0;
            while (n < 13)
            {
                Card card = new Card();
                card.Suit = "Diamond";
                // Assign the ActualValue depending on the FaceValue
                if (card.faceValues[n] == "J" | card.faceValues[n] == "Q" | card.faceValues[n] == "K")
                {
                    card.ActualValue = 10;
                }
                else if (card.faceValues[n] == "A")
                {
                    card.ActualValue = 11;
                }
                else
                {
                    string faceValueString = faceValues[n];
                    int faceValueInt = int.Parse(faceValueString);
                    card.ActualValue = faceValueInt;
                }
                card.FaceValue = faceValues[n];
                n++;

                diamonds.Add(card);

            }

            return diamonds;
        }
               
        private List<Card> GetSpades()
        {
            // create a copy of faceValues so we don't mess up the original faceValues later on
            string[] heartFaceValues = new string[faceValues.Length];

            Array.Copy(faceValues, heartFaceValues, faceValues.Length);

            List<Card> spades = new List<Card>();

            // create individual spade cards then add them to the spades list
            int n = 0;
            while (n < 13)
            {
                Card card = new Card();
                card.Suit = "Spades";
                // Assign the ActualValue depending on the FaceValue
                if (card.faceValues[n] == "J" | card.faceValues[n] == "Q" | card.faceValues[n] == "K")
                {
                    card.ActualValue = 10;
                }
                else if (card.faceValues[n] == "A")
                {
                    card.ActualValue = 11;
                }
                else
                {
                    string faceValueString = faceValues[n];
                    int faceValueInt = int.Parse(faceValueString);
                    card.ActualValue = faceValueInt;
                }
                card.FaceValue = faceValues[n];
                n++;

                spades.Add(card);

            }

            return spades;
        }

        private List<Card> GetClubs()
        {
            // create a copy of faceValues so we don't mess up the original faceValues later on
            string[] clubFaceValues = new string[faceValues.Length];

            Array.Copy(faceValues, clubFaceValues, faceValues.Length);

            List<Card> clubs = new List<Card>();

            // create individual heart cards then add them to the hearts list
            int n = 0;
            while (n < 13)
            {
                Card card = new Card();
                card.Suit = "Club";
                // Assign the ActualValue depending on the FaceValue
                if (card.faceValues[n] == "J" | card.faceValues[n] == "Q" | card.faceValues[n] == "K")
                {
                    card.ActualValue = 10;
                }
                else if (card.faceValues[n] == "A")
                {
                    card.ActualValue = 11;
                }
                else
                {
                    string faceValueString = faceValues[n];
                    int faceValueInt = int.Parse(faceValueString);
                    card.ActualValue = faceValueInt;
                }
                card.FaceValue = faceValues[n];
                n++;

                clubs.Add(card);

            }

            return clubs;
        }

        public List<Card> GetDeck()
        {
            List<Card> deck = new List<Card>();
            List<Card> heartDeck = new List<Card>();
            heartDeck = GetHearts();

            int n = 0;
            while (n < 13)
            {
                deck.Add(heartDeck[n]);
                n++;
            }

            List<Card> diamondDeck = new List<Card>();
            diamondDeck = GetDiamonds();

            n = 0;
            while (n < 13)
            {
                deck.Add(diamondDeck[n]);
                n++;
            }

            List<Card> spadeDeck = new List<Card>();
            spadeDeck = GetSpades();

            n = 0;
            while (n < 13)
            {
                deck.Add(spadeDeck[n]);
                n++;
            }

            List<Card> clubDeck = new List<Card>();
            clubDeck = GetClubs();

            n = 0;
            while (n < 13)
            {
                deck.Add(clubDeck[n]);
                n++;
            }

            
            return deck;
        }
    }
}
