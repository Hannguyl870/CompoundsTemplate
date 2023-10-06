using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compounds
{
    public partial class Form1 : Form
    {
        string suit = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void hurricaneButton_Click(object sender, EventArgs e)
        {
            //get the inputted category
           
            string scale  =categoryOutput.Text;

            //check the inputted category with a switch block
            switch(scale)
            {
                case "1":
                    categoryOutput.Text = "119-153 km/h";
                    break;
                case "2":
                    categoryOutput.Text = "154-177 km/h";
                    break;
                case "3":
                    categoryOutput.Text = "179-209 km/h";
                    break;
                case "4":
                    categoryOutput.Text = "210-149 km/h";
                    break;
                case "5":
                    categoryOutput.Text = "greater than 249";
                    break;
                default:
                    categoryOutput.Text = "only 1-5 are valid";
                    break;
            }
        }

        private void heartButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "hearts";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Goldenrod;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;
        }

        private void diamondButton_Click(object sender, EventArgs e)
        {
            //set suit value

            suit = "diamonds";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Goldenrod;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;
        }

        private void clubButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "clubs";
           

            //set button colour to goldenrod, (other buttons black)
             heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Goldenrod;
            spadeButton.BackColor = Color.Black;
        }

        private void spadeButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "spades";
            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Goldenrod;
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to check what suit
            //has been selected and output the colour of the suit
            if (suit == "hearts" || suit == "diamonds")
            {
                suitOutput.Text = "The suit is red";
            }
          
            else if (suit == "spades"|| suit == "clubs") 
            {
                suitOutput.Text = "the suit is black";
            }
            else
            {
                suitOutput.Text = "select a suit";
            }

        }

        private void thisButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
        }

        private void thatButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to give outputs based on 
            //if both colours are the same or different
        }
    }
}
