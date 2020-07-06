using System;
using System.Collections.Generic;
using System.Text;

namespace Texas_Hold_em_Poker
{
    class Deck
    {
        //Stores a list of cards
        List<Card> listOfCards;
        //Stores the random object
        Random rand;

        //Constructs a new deck
        public Deck(Random rand)
        {
            listOfCards = AddCards();
            this.rand = rand;

            AddCards();
            ShuffleDeck();
        }

        //Adds all of the cards to the deck
        private List<Card> AddCards()
        {
            List<Card> tempList = new List<Card>();
            //For each suit
            for(int i = 0; i < Enum.GetNames(typeof(Card.Suits)).Length; i++)
            {
                //For each value
                for(int j = 0; j < Enum.GetNames(typeof(Card.Values)).Length; j++)
                {
                    tempList.Add(new Card((Card.Values)j, (Card.Suits)j));
                }
            }
            return tempList;
        }

        //Shuffles the deck of cards
        private void ShuffleDeck()
        {
            List<Card> newlist = new List<Card>();
            int length = listOfCards.Count;

            //For each card in the old deck
            for(int i = 0; i < length; i++)
            {
                //Get a random number
                int index = rand.Next(listOfCards.Count);
                //Add that index to the new list
                newlist.Add(listOfCards[index]);
                //Removed that card from the old list
                listOfCards.RemoveAt(index);
            }
        }

        //Deals the first card of the deck
        public Card DealCard()
        {
            Card c = listOfCards[0];
            listOfCards.RemoveAt(0);
            return c;
        }
    }
}
