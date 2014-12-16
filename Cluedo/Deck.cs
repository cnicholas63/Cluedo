/* 
 * Chris Nicholas 16/12/14
 * Deck class holds the deck of cards
 * Provides methods for initialise, shuffle, get card by type, and get card from deck
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluedo
{
    class Deck
    {
        List<Card> cards; // List holding the cards
        String[] characters = {"Mark", "Collette", "Chris", "Dan", "Darryl", "Sally", "Peter" };
        String[] weapons = {"Pen Drive", "Power Cable", "Keyboard", "Stapler", "Soldering Iron", "Scissors", "Death by PowerPoint!" };
        String[] locations = { "CE011 The Big Guns", "School Office", "Lecture Theatre", "Laptop Lab", "Network Lab", "CE foyer", "Research Lab" };

        // Constructor
        public Deck()
        {
            // Create Crads and initialise
        }

        // Initialise the deck - sort all cards, into groups, etc.
        public void initialise() {

        }

        // Gets a suspect card from the unshuffled deck and remove it from deck
        public Card getSuspectCard() {
            
        }

        // Get a weapon card from the deck and remove it from deck
        public Card getWeaponCard()
        {

        }

        // Get a location card and remove it from deck
        public Card getLocationCard()
        {

        }

        // Shuffle the cards
        public void shuffle()
        {

        }

        // Get a card from the shuffled deck and remove it from deck
        public Card getCard()
        {

        }

    }


}
