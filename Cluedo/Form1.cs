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
        
        // Declare array with 24 elements of type button, these represent the board squares (not rooms)
        // The buttons will be created dynamically
        Button[] squares = new Button[24];

        // xPos and yPos arrays representing the X and Y coordinates of the buttons
        int[] xPos = { 0, 75, 150, 225, 300, 375, 450, 450, 450, 450, 450, 450, 450, 375, 300, 225, 150, 75, 0, 0, 0, 0, 0, 0};
        int[] yPos = { 0, 0, 0, 0, 0, 0, 0, 75, 150, 225, 300, 375, 450, 450, 450, 450, 450, 450, 450, 375, 300, 225, 150, 75};
        int xOffset = 250; // Offset from left hand side 
        int yOffset = 100;




        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Hello";

//            button7.Click += new System.EventHandler(this.myEventHandler);

            for(int t = 0; t < squares.Length; t++) {
                squares[t] = createButton("Square " + t, 75, 75, xPos[t] + xOffset, yPos[t] + yOffset);
                squares[t].Click += new System.EventHandler(this.myEventHandler);
                this.Controls.Add(squares[t]);
            }
            
//            myButton = createButton("Dynamic Button", 100, 100, 100, 100);
//            myButton.Click += new System.EventHandler(this.myEventHandler);
//            this.Controls.Add(myButton);
//            Console.WriteLine("Button should be added");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");

            //System.Windows.Forms.PictureBox pb = new PictureBox()
 
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
        }

        private void myEventHandler(object sender, EventArgs e)
        {
            textBox1.Text = "Using my event handler";

        }

        private Button createButton(String label, int width, int height, int topLeft, int topRight)
        {
            Button button = new Button();

            button.Text = label;

            button.Width = width;
            button.Height = height;
            button.Location = new Point(topLeft, topRight);

            return button;


        }



    }
}
