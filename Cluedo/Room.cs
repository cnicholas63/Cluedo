/*
 * Chris Nicolas 16/12/14
 * The Room class manages information about a room
 * this includes allowing visitors to enter and leave the room,
 * holds a list of any suspects visiting the room
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
        private List<Suspect> visitors; // Declare List of type String that will hold visitors to the room
        private List<String> objects;  // Declare List of type String that will hold objects in the room
        private String roomName; // Name of the room

        // Room constructor
        public Room(String roomName)
        {
            this.roomName = roomName; // Name the room
            visitors = new List<Suspect>(); // Initialise empty list of visitors to the room
            objects = new List<String>();  // Initialise empty list of objects in the room 
        }

        
        // Suspect enters the room - Returns an False if the person is already there
        public Boolean AddVisitor(Suspect suspect)
        {
            //foreach (Suspect sus in visitors) // Is the suspect already in the room?
            //{
            //    if (suspect.name.Equals(sus.name))
            //    {  // Error, this person is already in this room
            //        return false;
            //    }
            //}

            foreach (Suspect vis in visitors)
            {
                if (suspect == vis) // Is this person is already in the room?
                {                    // If Yes, Error 

                    Console.WriteLine("Visitor " + suspect.name + " Already in room");
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
            //foreach (Suspect vis in visitors)
            //{ // Is the suspect in the room?
            //    if (suspect.name.Equals(vis.name))
            //    {
            //        visitors.Remove(vis);       // Remove visitor from the list
            //        Console.WriteLine("Visior left the room: " + suspect.name); ///////// Debug Delete when finished

            //        return true; // Success
            //    }
            //}
            
            foreach (Suspect vis in visitors)
            { // Is the suspect in the room?
                if (suspect == vis)
                {
                    visitors.Remove(vis);       // Remove visitor from the list
                    Console.WriteLine("Visior left the room: " + suspect.name); ///////// Debug Delete when finished

                    return true; // Success
                }
            }


            return false; // Error, the visitor was not in the room
        }

        // Returns the number of visitors in the room
        public int Count() 
        {
            return visitors.Count;
        }


        // Lists to the console any visitors in the room
        public Boolean ListVisitors()
        {
            int t = 0;

            if (visitors.Count == 0)
            {
                Console.WriteLine("No visitors!");
                return false;
            }


            foreach (Suspect vis in visitors)
            {
                Console.WriteLine("Visitor " + t + " = " + vis.name);
                t++;
            }

            return true;
        }

    }
}
