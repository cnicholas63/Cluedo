/*
 * Chris Nicholas 17/12/14
 * BoardSqaure class holds information about the board squares including
 * a Button and a reference to a room (if the square is an entrance)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluedo
{
    class BoardSquare
    {
        public Button square; // The square represented as a button on the form
        public Room room; // Reference to a room if this board square is an entry or NULL if not

        // Constructor constructs a square with no room reference
        public BoardSquare()
        {
            room = null; // No room reference supplied so set to null
        }

        // Overload constructor constructs a square with a room reference
        public BoardSquare(Room room)
        {
            addRoom(room); // Add a the room reference to the room
        }

        // Adds a reference to a room - can be called after construction if necessary
        public void addRoom(Room room) {
            this.room = room;
        }
    }
}
