using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Texas_Hold_em_Poker
{
    class Card
    {
        //The possible suits of a card
        public enum Suits { Clubs, Spades, Diamonds, Hearts};
        //The possible values of a card
        public enum Values { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Jack, Queen, King};

        //Stores the values of the card
        private Values value;
        private Suits suit;

        //Constructs a card
        public Card(Values v, Suits s)
        {
            value = v;
            suit = s;
        }

        //Gets the suit of the card
        public Suits Suit
        {
            get { return suit; }
        }

        //Gets the value of the card
        public Values Value
        {
            get { return value; }
        }
    }
}
