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
    public partial class arcadeForm : Form
    {

        private mainForm mainForm;
        private string userAnswer;
        private bool puzzleSolved;

        public arcadeForm(mainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            puzzleSolved = false;

            arcadeLabel.Text = "Howard, Philip, and Joyce: among them is a good man, a bad man, and a liar.\n" +
                               "The good man only tells the truth; the bad man only lies; and the liar...\n" +
                               "Well, he would say anything sometimes the truth, and sometimes lies.\n" +
                               "One day, Joyce said: Philip is either the good man or the bad man.\n" +
                               "Then, Philip said: Either Howard or Joyce is the good man.\n" +
                               "Which of these three is the liar? Howard(h), Joyce(j), or Philip(p)?";

            promptLabel.Text = "Please enter the initials of your choice in the textbox and press confirm.\n" +
                               "e.g. j for Joyce";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            userAnswer = answerTextBox.Text.ToLower().Trim();

            if (userAnswer == "p" || userAnswer == "philip")
            {
                promptLabel.Text = "Your answer is correct!";
                MessageBox.Show("Your answer is correct!");

                puzzleSolved = true;
                this.Hide();
                mainForm.SolvedArcadePuzzle();
            }
            else
            {
                promptLabel.Text = "Your answer is incorrect";
            }
        }

        private void arcadeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!puzzleSolved)
            {
                e.Cancel = true;
                MessageBox.Show("Please solve the puzzle before closing");
            }
        }
    }
}

//puzzle from https://game8.co/games/Honkai-Star-Rail/archives/409802