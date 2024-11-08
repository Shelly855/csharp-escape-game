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
    public partial class padlockForm : Form
    {
        private mainForm mainForm;
        //reference: https://social.msdn.microsoft.com/Forums/vstudio/en-US/6989594d-3ad9-4bc9-aa2c-98f0a59378b8/how-to-call-a-method-from-another-form-in-c-and-windows-forms?forum=csharpgeneral

        private int padlockCodeOne;
        private int padlockCodeTwo;
        private int padlockCodeThree;
        public padlockForm(mainForm mainForm, int codeOne, int codeTwo, int codeThree)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            padlockCodeOne = codeOne;
            padlockCodeTwo = codeTwo;
            padlockCodeThree = codeThree;

            padlockLabel.Text = "You lift up the padlock to see that it is a 3-digit combination padlock marked with a blue rune.\n" +
                                "Please enter a 3-digit code.";
        }

        private void CheckPadlockCode()
        {
            if (int.TryParse(windowPadlockNo1.Text, out int inputCodeOne) &&
                int.TryParse(windowPadlockNo2.Text, out int inputCodeTwo) &&
                int.TryParse(windowPadlockNo3.Text, out int inputCodeThree))
            {
                if (inputCodeOne == padlockCodeOne && inputCodeTwo == padlockCodeTwo && inputCodeThree == padlockCodeThree)
                {
                    MessageBox.Show("Padlock unlocked!");
                    this.Close();
                    mainForm.UnlockedPadlock();
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void windowPadlockNo1Left_Click(object sender, EventArgs e)
        {
            if (int.TryParse(windowPadlockNo1.Text, out int windowPadlockNo1Number))
            {
                if (windowPadlockNo1Number > 0)
                {
                    windowPadlockNo1Number -= 1;
                }
                else
                {
                    windowPadlockNo1Number = 9;
                }

                windowPadlockNo1.Text = windowPadlockNo1Number.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            CheckPadlockCode();
        }

        private void windowPadlockNo1Right_Click(object sender, EventArgs e)
        {
            if (int.TryParse(windowPadlockNo1.Text, out int windowPadlockNo1Number))
            {
                if (windowPadlockNo1Number < 9)
                {
                    windowPadlockNo1Number += 1;
                }
                else
                {
                    windowPadlockNo1Number = 0;
                }

                windowPadlockNo1.Text = windowPadlockNo1Number.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            CheckPadlockCode();
        }

        private void windowPadlockNo2Left_Click(object sender, EventArgs e)
        {
            if (int.TryParse(windowPadlockNo2.Text, out int windowPadlockNo2Number))
            {
                if (windowPadlockNo2Number > 0)
                {
                    windowPadlockNo2Number -= 1;
                }
                else
                {
                    windowPadlockNo2Number = 9;
                }

                windowPadlockNo2.Text = windowPadlockNo2Number.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            CheckPadlockCode();
        }

        private void windowPadlockNo2Right_Click(object sender, EventArgs e)
        {
            if (int.TryParse(windowPadlockNo2.Text, out int windowPadlockNo2Number))
            {
                if (windowPadlockNo2Number < 9)
                {
                    windowPadlockNo2Number += 1;
                }
                else
                {
                    windowPadlockNo2Number = 0;
                }

                windowPadlockNo2.Text = windowPadlockNo2Number.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            CheckPadlockCode();
        }

        private void windowPadlockNo3Left_Click(object sender, EventArgs e)
        {
            if (int.TryParse(windowPadlockNo3.Text, out int windowPadlockNo3Number))
            {
                if (windowPadlockNo3Number > 0)
                {
                    windowPadlockNo3Number -= 1;
                }
                else
                {
                    windowPadlockNo3Number = 9;
                }

                windowPadlockNo3.Text = windowPadlockNo3Number.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            CheckPadlockCode();
        }

        private void windowPadlockNo3Right_Click(object sender, EventArgs e)
        {
            if (int.TryParse(windowPadlockNo3.Text, out int windowPadlockNo3Number))
            {
                if (windowPadlockNo3Number < 9)
                {
                    windowPadlockNo3Number += 1;
                }
                else
                {
                    windowPadlockNo3Number = 0;
                }

                windowPadlockNo3.Text = windowPadlockNo3Number.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            CheckPadlockCode();
        }

        //reference = https://josipmisko.com/posts/c-sharp-tryparse
    }
}
