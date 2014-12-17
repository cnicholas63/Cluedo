using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;


namespace Cluedo
{
    public partial class Form1 : Form
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        private Button myButton;
        
        // Declare array with 24 elements of type BoardSquare, these represent the board squares (not rooms)
        // The BoardSquare buttons will be created dynamically
        BoardSquare[] squares = new BoardSquare[24];

        String[] names = { "Chris", "Jeni", "Craig", "Warren", "Melissa", "Ethan", "Megan", "Keira", "Grace" };
        Suspect[] suspects = new Suspect[9];

        // xPos and yPos arrays representing the X and Y coordinates of the buttons
        int[] xPos = { 0, 75, 150, 225, 300, 375, 450, 450, 450, 450, 450, 450, 450, 375, 300, 225, 150, 75, 0, 0, 0, 0, 0, 0};
        int[] yPos = { 0, 0, 0, 0, 0, 0, 0, 75, 150, 225, 300, 375, 450, 450, 450, 450, 450, 450, 450, 375, 300, 225, 150, 75};
        int xOffset = 250; // Offset from left hand side 
        int yOffset = 100;

        /* 
         * Initialise the main form
         */
        public Form1()
        {
            InitializeComponent();


//            button7.Click += new System.EventHandler(this.myEventHandler);
//            myButton = createButton("Dynamic Button", 100, 100, 100, 100);
//            myButton.Click += new System.EventHandler(this.myEventHandler);
//            this.Controls.Add(myButton);
//            Console.WriteLine("Button should be added");

            drawBoard(); // Draw board components

            Room room = new Room("Computer Room");

            for (int t = 0; t < names.Length; t++)
            {
                suspects[t] = new Suspect(names[t], t);

                if (!room.AddVisitor(suspects[t]))
                {
                    Console.WriteLine("Visitor Already in Room: " + suspects[t]);
                }


            }

            room.ListVisitors();

            suspects[7].room = 0;

            if (!room.AddVisitor(suspects[7]))
            {
                Console.WriteLine("ERROR WRONG VISITOR");
            }
            
            int j = 0;
            // TRY DELETING ALL VISITORS
            while (room.Count() > 0)
            {
                
                room.RemoveVisitor(suspects[j++]);
            }

            Console.WriteLine("Room is empty");
            room.ListVisitors();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Draw components onto the board
        private void drawBoard()
        {
            textBox1.Text = "Hello";

            // Board squares are actually form buttons
            // For loop to instantiate and draw squares onto the board
            // Dynamically create buttons, give them an event handler and place on the board
            for(int t = 0; t < squares.Length; t++) {
                squares[t] = new BoardSquare(); // Construct the board square
                squares[t].square = createButton("Square " + t, 75, 75, xPos[t] + xOffset, yPos[t] + yOffset); // Add form button to square
                squares[t].square.Click += new System.EventHandler(this.myEventHandler); // Add event handler to the square
                this.Controls.Add(squares[t].square); // Add the square to the board
            } 

            // Draw rooms onto the board

            this.Controls.Add(new RoomPanel("Computer Lab").panel);

        }

        // Deal Cards
        private void dealCards()
        {

        }

        // Initialise the players
        private void iniPlayers()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
//            Console.WriteLine("Hello There");
//            MessageBox.Show("Hello Again", "MyMessage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation); // A message box with Yes, No and Cancel buttons

 

            if (textBox1.Text == "")
                return;



            QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
            pictureBox1.BackgroundImage = qrCode.GetGraphic(20); // Generate QR code and store in picture box

            button1.Text = textBox1.Text;
            label2.Text = textBox1.Text;
        }

        private void myEventHandler(object sender, EventArgs e)
        {
            textBox1.Text = "Using my event handler";

        }

        
        // This method creates a  button dynamically, according to the parameters recieved
        // It does not place the button on a form or give it an even listener
        private Button createButton(String label, int width, int height, int topLeft, int topRight)
        {
            Button button = new Button();   // Instantiate button

            button.Text = label;            // Assign label

            button.Width = width;           // Set the width
            button.Height = height;         // Set the height
            button.Location = new Point(topLeft, topRight); // Set the button location

            return button; // Return the button
        }

    }
}
