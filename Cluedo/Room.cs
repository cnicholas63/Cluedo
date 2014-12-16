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
//        ArrayList<Suspect> susp;

        List<Suspect> visitors; // Declare List of type String that will hold visitors to the room
        List<String> objects;  // Declare List of type String that will hold objects in the room

        // Room constructor
        public Room()
        {
            visitors = new List<Suspect>(); // Initialise empty list of visitors to the room
            objects = new List<String>();  // Initialise empty list of objects in the room 
        }

        
        // Suspect enters the room - Returns an False if the person is already there
        public Boolean AddVisitor(Suspect suspect)
        {
            foreach (Suspect sus in visitors) // Is the suspect already in the room?
            {
                if (suspect.name.Equals(sus.name))
                {  // Error, this person is already in this room
                    return false;
                }
            }
            visitors.Add(suspect); // Add visitor to the list

            Console.WriteLine("Visitor entered the room: " + suspect.name); ///////// Debug Delete when finished
            return true; // Visitor successfully entered the room
        }

        // Suspect leaves the room
        // Returns true if successful, false if the suspect cannot be found in the room
        public Boolean RemoveVisitor(Suspect suspect)
        {
            foreach (Suspect vis in visitors)
            { // Is the suspect in the room?
                if (suspect.name.Equals(vis.name))
                {
                    visitors.Remove(vis);       // Remove visitor from the list
                    Console.WriteLine("Visior left the room: " + suspect.name); ///////// Debug Delete when finished

                    return true; // Success
                }
            }

            return false; // Error, the visitor was not in the room
        }
    }
}
