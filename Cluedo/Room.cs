/*
 * Chris Nicolas 16/12/14
 * The Room class hold information about a room
 * this includes a list of any suspects visiting the room
 * and objects stored in the room
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluedo
{
    class Room
    {
        ArrayList<Suspect> susp;

        List<Suspect> visitors; // Declare List of type String that will hold visitors to the room
        List<String> objects;  // Declare List of type String that will hold objects in the room

        // Room constructor
        public Room()
        {
            visitors = new List<Suspect>(); // Initialise empty list of visitors to the room
            objects = new List<String>();  // Initialise empty list of objects in the room 
        }

        
        // Suspect enters the room
        public void AddVisitor(Suspect suspect)
        {

        }

        // Suspect leaves the room
        // Returns true if successful, false if the suspect cannot be found in the room
        Boolean RemoveVisitor(Suspect suspect)
        {
            foreach(Suspect vis in visitors ) {
                if()


            }


                return true;
        }



    }
}
