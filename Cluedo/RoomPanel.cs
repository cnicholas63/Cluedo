/* 
 * Chris Nicholas 17/12/14
 * RoomPanel defines a panel that will be placed onto the game board and represents rooms within the game
 * The RoomPanel holds 2 multiline textboxes, 1 for visitors and 1 for weapons
 * These will be used to display the visitors to the room and weapons
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluedo
{
    class RoomPanel
    {
        private int panelWidth = 151;     // Width of text box
        private int panelHeight = 150;   // Height of text box
        private int textWidth = 75;
        private int textHeight = 125;

        public Panel panel;         // Panel represents a room on the board and holds visitors and weapons
        private TextBox visitors;   // Will display the list of visitors
        private TextBox weapons;    // Will display the list of weapons
        private Label roomName;     // Label to hold the name of the room

        // Constructor, constructs the panel and adds the visitor and weapon textboxes
        public RoomPanel(String name)
        {
            panel = new Panel(); // Instantiate a panel
            panel.Width = panelWidth;
            panel.Height = panelHeight;
            panel.Location = new Point(50, 200);

            panel.BackColor = Color.Chocolate;

            roomName = new Label();   // instantiate a label for the room name
            roomName.Width = panel.Width; // Width of the label
            roomName.TextAlign = ContentAlignment.MiddleCenter; // Center the text within the label
            roomName.Location = new Point(0, 0);

            roomName.Text = name;

            panel.Controls.Add(roomName);

            visitors = makeTextBox("Visitors", textWidth, textHeight);       // Instantiate a text box for visitor names
            weapons = makeTextBox("Weapons", textWidth, textHeight);        // Instantiate a text box for weapon names

            visitors.Location = new Point(0, roomName.Height); // Top left of text box

            weapons.Location = new Point(textWidth + 1, roomName.Height); // Place weapons list to the right of visitors list

            panel.Controls.Add(visitors);
            panel.Controls.Add(weapons);
        }

        // Makes a textbox for room panel based on specified attributes
        private TextBox makeTextBox(String name, int width, int height)
        {
            TextBox tb = new TextBox(); // Instantiate a TextBox

            tb.Multiline = true; // Set this textbox as multiline
            tb.Width = width;    // Width of text box
            tb.Height = height;  // Height of textbox
            tb.ReadOnly = true;  // Set textbox to read only (user can't type into field)
            tb.Text = name;

            return tb;
        }

    }
}
