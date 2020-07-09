using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Texas_Hold_em_Poker
{
    class Game
    {
        //Stores the players in the game
        List<Player> listOfPlayers;
        //Stores the deck of the game
        Deck deck;
        //Stores the cards which have been played on the table
        List<Card> tabledCards;

        //Constructs a new game
        public Game(Random rand)
        {
            //Initialises the lists
            listOfPlayers = new List<Player>();
            deck = new Deck(rand);
            tabledCards = new List<Card>();

            Debug.WriteLine(deck.ToString());
        }
    }
}
