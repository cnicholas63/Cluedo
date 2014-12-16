/*
 * Chris Nicholas 16/12/14
 * Card class holds the details of a card. All card types use Card
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluedo
{
    class Card
    {
        public String name; // Name of the card
        public int type;    // Type of card, e.g. suspect, weapon. location

        // Constructor, accepts the details for a card
        public Card(String name, int type) 
        {
            this.name = name;
            this.type = type;
        }


    }
}

