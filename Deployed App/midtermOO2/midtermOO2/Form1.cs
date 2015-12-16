/*
Program Author: ANdrew Bylander
Program Date: 11/17/15
Program Description: Create a Form with a ListBox that lists at least four sports teams of your choice. 
When the user places the mouse over the ListBox, display a Label that contains single-game ticket prices 
for each team. The Label disappears when the user’s mouse leaves the ListBox area. When the user clicks 
a team name in the ListBox, display another Label that contains the correct ticket price and change the 
BackColor of the Form to the selected team’s color. 

Create options for the user to select a date from a calendar and number of tickets wanted. When a user 
clicks a button, compute the total cost and display the date when the event is. The form should also have 
a MenuStrip where the main menu File and Help must exist and menu options are left for you to design.  
Save the project as TeamSelector.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midtermOO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public const int PACKERS = 55;
        public const int VIKINGS = 50;
        public const int BEARS = 35;
        public const int LIONS = 20;
        public int TicketPrice;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                label2.Visible = true;
                label2.Text = PACKERS.ToString("C");
                TicketPrice = PACKERS;
                this.BackColor = Color.Green;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                label2.Visible = true;
                label2.Text = VIKINGS.ToString("C");
                TicketPrice = VIKINGS;
                this.BackColor = Color.Purple;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                label2.Visible = true;
                label2.Text = BEARS.ToString("C");
                TicketPrice = BEARS;
                this.BackColor = Color.Orange;
            }
            else 
            {
                label2.Visible = true;
                label2.Text = LIONS.ToString("C");
                TicketPrice = LIONS;
                this.BackColor = Color.LightBlue;
            }
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfTickets;
            if (textBox1.Text.Equals(""))
               numberOfTickets = 0;
            else
            numberOfTickets = Convert.ToInt32(textBox1.Text);


            int totalTicketPrice = numberOfTickets * TicketPrice;
            label6.Visible = true;
            label6.Text = totalTicketPrice.ToString("C");

        }

        private void showHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
        }
    }
}
