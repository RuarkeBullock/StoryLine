using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryLine
{
    public partial class Form1 : Form
    {
        // tracks what page of the story the user is at
        int page = 1;
        private object close;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///Check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }

            else if (page == 2)
            {
                page = 5;
            }

            else if (page == 3)
            {
                page = 1;
            }

            else if (page == 4)
            {
                page = 1;
            }

            else if (page == 5)
            {
                page = 7;
            }

            else if (page == 6)
            {
                page = 1;
            }

            else if (page == 7)
            {
                page = 10;
            }

            else if (page == 8)
            {
                page = 1;
            }

            else if (page == 9)
            {
                page = 1;
            }

            else if (page == 10)
            {
                page = 12;
            }

            else if (page == 11)
            {
                page = 1;
            }

            else if (page == 12)
            {
                page = 14;
            }

            else if (page == 13)
            {
                page = 1;
            }

            else if (page == 14)
            {
                page = 16;
            }

            else if (page == 15)
            {
                page = 99;
            }

            else if (page == 16)
            {
                page = 18;
            }

            else if (page == 17)
            {
                page = 1;
            }

            else if (page == 18)
            {
                page = 20;
            }

            else if (page == 19)
            {
                page = 1;
            }

            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 99)
            {
                page = 1;
            }


            DisplayPage();


          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 99;
            }

            else if (page == 4)
            {
                page = 99;
            }

            else if (page == 5)
            {
                page = 6;
            }

            else if (page == 6)
            {
                page = 99;
            }

            else if (page == 7)
            {
                page = 9;
            }

            else if (page == 8)
            {
                page = 99;
            }

            else if (page == 9)
            {
                page = 99;
            }

            else if (page == 10)
            {
                page = 11;
            }

            else if (page == 11)
            {
                page = 99;
            }

            else if (page == 12)
            {
                page = 13;
            }

            else if (page == 13)
            {
                page = 99;
            }

            else if (page == 14)
            {
                page = 15;
            }

            else if (page == 15)
            {
                page = 99;
            }

            else if (page == 16)
            {
                page = 17;
            }

            else if (page == 17)
            {
                page = 99;
            }

            else if (page == 18)
            {
                page = 19;
            }

            else if (page == 19)
            {
                page = 99;
            }

            else if (page == 20)
            {
                page = 99;
            }

            else if (page == 99)
            {
                page = 1;
            }

            DisplayPage();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }

            else if (page == 2)
            {
                page = 5;
            }

            else if (page == 3)
            {
                page = 99;
            }

            else if (page == 4)
            {
                page = 99;
            }

            else if (page == 5)
            {
                page = 7;
            }

            else if (page == 6)
            {
                page = 99;
            }

            else if (page == 7)
            {
                page = 8;
            }

            else if (page == 8)
            {
                page = 99;
            }

            else if (page == 9)
            {
                page = 99;
            }

            else if (page == 10)
            {
                page = 12;
            }

            else if (page == 11)
            {
                page = 99;
            }

            else if (page == 12)
            {
                page = 14;
            }

            else if (page == 13)
            {
                page = 99;
            }

            else if (page == 14)
            {
                page = 16;
            }

            else if (page == 15)
            {
                page = 99;
            }

            else if (page == 16)
            {
                page = 18;
            }

            else if (page == 17)
            {
                page = 99;
            }

            else if (page == 18)
            {
                page = 20;
            }

            else if (page == 19)
            {
                page = 99;
            }

            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 1;
            }


            DisplayPage();
        }

        public void DisplayPage()
        {
            soundplayer sp = new soundplayer(Properties.Resources.Scary_Sound_Mark_DiAngelo_1101865305);

            switch (page)
            {
                case 1:
                    topLabel.Text = "you are in a big mansion";
                    option1Label.Text = "go right";
                    option2Label.Text = "go left";
                    break;
                case 2:
                    topLabel.Text = "you have come to a stop";
                    option1Label.Text = "left";
                    option2Label.Text = "right";
                    break;
                case 3:
                    topLabel.Text = "you come across P.Diddy. He molests you. Play Again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    topLabel.Text = "you fall down and P.Diddy molests you. Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 5:
                    topLabel.Text = "you walk by food do you eat it?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 6:
                    topLabel.Text = "the food was amazing. but it was laced and you die. Play again.";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 7:
                    topLabel.Text = "you walk by the food and come to across 3 doors";
                    option1Label.Text = "red";
                    option2Label.Text = "green";
                    option3Label.Text = "blue";
                    break;
                case 8:
                    topLabel.Text = "you call into a pit and die. Play Again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    option3Label.Text = "";
                    break;
                case 9:
                    topLabel.Text = "you slip and fall on his baby oil. Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 10:
                    topLabel.Text = "you come across diddy's room, but he heard you. where do you hide";
                    option1Label.Text = "in the closet";
                    option2Label.Text = "under the bed";
                    break;
                case 11:
                    topLabel.Text = "Diddy finds you with no clothes on. Play Again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 12:
                    topLabel.Text = "you find a hidden door in the cloest. do you go threw?";
                    option1Label.Text = "leave";
                    option2Label.Text = "go threw";
                    break;
                case 13:
                    topLabel.Text = "hes at the other side and is waiting for you. Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 14:
                    topLabel.Text = "you make it out of the house how do you leave";
                    option1Label.Text = "car";
                    option2Label.Text = "bike";
                    break;
                case 15:
                    topLabel.Text = "he catches you becasue you were too slow. Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 16:
                    topLabel.Text = "you get away but run out of gas. what way do you go?";
                    option1Label.Text = "south";
                    option2Label.Text = "north";
                    break;
                case 17:
                    topLabel.Text = "you run back toawds the house and he finds you. Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 18:
                    topLabel.Text = "you find yourself cornered by diddy. denfend yourself";
                    option1Label.Text = "shovel";
                    option2Label.Text = "big branch";
                    break;
                case 19:
                    topLabel.Text = "he takes the branch from you and eats you. Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 20:
                    topLabel.Text = "you are able to get away because you killed him. Play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 99:
                    topLabel.Text = "would you like to play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    Refresh();
                    Thread.Sleep(1000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
