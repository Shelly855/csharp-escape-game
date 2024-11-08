using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingCourseworkGUI
{
    public partial class tutorialForm : Form
    {
        public tutorialForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (numberLabel.Text == "1")
            {
                DisplayTutorialPageTwo();
            }
            else if (numberLabel.Text == "2")
            {
                DisplayTutorialPageThree();
            }
            else if (numberLabel.Text == "3")
            {
                DisplayTutorialPageFour();
            }
            else if (numberLabel.Text == "4")
            {
                DisplayTutorialPageFive();
            }
            else if (numberLabel.Text == "5")
            {
                DisplayTutorialPageSix();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (numberLabel.Text == "1")
            {
                DisplayTutorialPageOne();
            }
            else if (numberLabel.Text == "2")
            {
                DisplayTutorialPageOne();
            }
            else if (numberLabel.Text == "3")
            {
                DisplayTutorialPageTwo();
            }
            else if (numberLabel.Text == "4")
            {
                DisplayTutorialPageThree();
            }
            else if (numberLabel.Text == "5")
            {
                DisplayTutorialPageFour();
            }
            else if (numberLabel.Text == "6")
            {
                DisplayTutorialPageFive();
            }
        }

        public void DisplayTutorialPageOne()
        {
            numberLabel.Text = "1";
            tutorialLabel.Text = "Progress through the locations, collect items and solve puzzles.";
        }

        private void DisplayTutorialPageTwo()
        {
            numberLabel.Text = "2";
            tutorialLabel.Text = "To choose an option, type in the text box under Your Choice and\n" +
                                 "press enter.";
        }

        private void DisplayTutorialPageThree()
        {
            numberLabel.Text = "3";
            tutorialLabel.Text = "Every time you collect an item, it will show in the box under\n" +
                                 "the title Your Inventory. Click on an item to see more about it.";
        }

        private void DisplayTutorialPageFour()
        {
            numberLabel.Text = "4";
            tutorialLabel.Text = "Inventory items will be automatically used when they are needed.";
        }

        private void DisplayTutorialPageFive()
        {
            numberLabel.Text = "5";
            tutorialLabel.Text = "To access this tutorial again, press the button on the right side\n" +
                                 "of the main screen.";
        }

        private void DisplayTutorialPageSix()
        {
            numberLabel.Text = "6";
            tutorialLabel.Text = "END";
            MessageBox.Show("End of Tutorial");
            this.Hide();
        }

        private void tutorialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (numberLabel.Text != "6")
            {
                e.Cancel = true;

                MessageBox.Show("Please complete the tutorial before closing");
            }
            else
            {
                e.Cancel = false;
            }
        } //reference = https://stackoverflow.com/questions/19641427/formclosing-and-formclosed-events-do-not-work
    }
}
