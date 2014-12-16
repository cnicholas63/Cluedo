/*
 * Chris Nicholas 16/12/14
 * The Suspect class holds information about suspects
 * including name, location, etc.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluedo
{

    class Suspect
    {
        public String name; // Suspects name
        public int room;    // Suspects room location (if not on a square)
        public int square;  // Board square that the suspect is on (if not in a room)

        // Constructor requires suspect's name and location (room index no)
        // Suspects start the game in a room, so no square location is needed
        public Suspect(String name, int room)
        {
            this.name = name; // Initialise suspect's name
            this.room = room; // Initialise suspect's room location
            square = -1;      // indicates that the suspect is not on a square
        }



    }
}
