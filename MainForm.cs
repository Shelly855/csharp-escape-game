using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ProgrammingCourseworkGUI
{
    public partial class mainForm : Form
    {
        // Other forms
        private tutorialForm tutorialForm;
        private arcadeForm arcadeForm;

        // To track status of puzzles and events
        private bool arcadePuzzleSolved = false;
        private bool fortuneTold = false; //for PickUpBox
        private bool padlockUnlocked = false;

        // List to contain items collected by player
        private List<Inventory> inventory = new List<Inventory>();

        // Holds health and energy stats
        private PlayerStats playerOne = new PlayerStats();

        // For the 3-digit padlock code
        private int padlockCodeOne;
        private int padlockCodeTwo;
        private int padlockCodeThree;

        // Declaring items
        private Inventory torch;
        private Inventory bronzeKey;
        private Inventory goldenBell;
        private Inventory redCoin;
        private Inventory orangeJewel;
        private Inventory blueJewel;
        private Inventory blackJewel;
        private Inventory extractOfText;

        public mainForm()
        {
            InitializeComponent();

            UserStats();

            inventoryListBox.SelectedIndexChanged += InventoryListBox_SelectedIndexChanged;

            tutorialForm = new tutorialForm();
            arcadeForm = new arcadeForm(this);

            // Initialising items and setting their properties
            torch = new Inventory();
            torch.name = "Torch";
            torch.description = "A torch that still has some battery left.";
            torch.rarity = "Common";
            torch.locationFound = "Cabinet Drawer";

            redCoin = new Inventory();
            redCoin.name = "Red Coin";
            redCoin.description = "A shiny red coin inscribed with a cat on one side.";
            redCoin.rarity = "Rare";
            redCoin.locationFound = "Cabinet Drawer";

            orangeJewel = new Inventory();
            orangeJewel.name = "Orange Jewel";
            orangeJewel.description = "An orange jewel that glitter with different hues of red, orange and yellow.";
            orangeJewel.rarity = "Super Rare";
            orangeJewel.locationFound = "Arcade Machine";

            bronzeKey = new Inventory();
            bronzeKey.name = "Bronze Key";
            bronzeKey.description = "A small bronze key.";
            bronzeKey.rarity = "Common";
            bronzeKey.locationFound = "Window";

            goldenBell = new Inventory();
            goldenBell.name = "Golden Bell";
            goldenBell.description = "A small golden bell that rings with a distorted tune.";
            goldenBell.rarity = "Rare";
            goldenBell.locationFound = "Picture Frame";

            blueJewel = new Inventory();
            blueJewel.name = "Blue Jewel";
            blueJewel.description = "A jewel that twinkles with a dark blue light.";
            blueJewel.rarity = "Super Rare";
            blueJewel.locationFound = "Arcade Machine";

            blackJewel = new Inventory();
            blackJewel.name = "Black Jewel";
            blackJewel.description = "A obsidian jewel that is as dark as night.";
            blackJewel.rarity = "Super Rare";
            blackJewel.locationFound = "Right Curtain";

            extractOfText = new Inventory();
            extractOfText.name = "Piece of Paper";
            extractOfText.description = "An extract of text about runes etc.";
            extractOfText.rarity = "Common";
            extractOfText.locationFound = "Bed";

            // Generates random padlock code with three digits
            Random random = new Random();
            padlockCodeOne = random.Next(1, 9);
            padlockCodeTwo = random.Next(1, 9);
            padlockCodeThree = random.Next(1, 9);

            // Sets form to open in maximized window state
            this.WindowState = FormWindowState.Maximized;

            // List of location choices
            List<string> choice = new List<string>();
            {
                choice.Add("Cabinet(c)");
                choice.Add("Bed(b)");
                choice.Add("Window(w)");
            }

            locationLabel.Text = "Room";

            mainLabel.Text = "Your task is to escape the room.\n" +
                              "Please enter the initials of your choice from the options below into the text box and press enter:\n" +
                              "(e.g. c for Cabinet)\n\n";

            for (int i = 0; i < choice.Count; i++)
            {
                mainLabel.Text += $"- {choice[i]}\n";
            }

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string userInput = choiceTextBox.Text.ToLower().Trim();

            if (userInput == "c" && locationLabel.Text == "Room")
            {
                choiceTextBox.Clear();

                CabinetOptions();
            }
            else if (userInput == "td" && locationLabel.Text == "Cabinet")
            {
                choiceTextBox.Clear();

                OpenTopDrawer();

            }
            else if (userInput == "md" && locationLabel.Text == "Cabinet")
            {
                choiceTextBox.Clear();

                OpenMiddleDrawer();
            }
            else if (userInput == "bd" && locationLabel.Text == "Cabinet")
            {
                choiceTextBox.Clear();

                OpenBottomDrawer();
            }
            else if (userInput == "b" && locationLabel.Text == "Cabinet")
            {
                choiceTextBox.Clear();

                PickUpBox();
            }
            else if (userInput == "w" && locationLabel.Text == "Room")
            {
                choiceTextBox.Clear();

                WindowOptions();

            }
            else if (userInput == "pa")
            {
                choiceTextBox.Clear();

                TryPadlock();
            }
            else if (userInput == "pi")
            {
                choiceTextBox.Clear();

                ExaminePictureFrame();
            }
            else if (userInput == "lc")
            {
                choiceTextBox.Clear();

                ExamineLeftCurtain();
            }
            else if (userInput == "yes" && locationLabel.Text == "Left Curtain")
            {
                choiceTextBox.Clear();

                if (inventory.Contains(redCoin))
                {
                    arcadeForm.Show();
                }
                else
                {
                    subOptionLabel.Text = "You need a coin to start the machine";
                }
            }
            else if (userInput == "no" && locationLabel.Text == "Left Curtain")
            {
                choiceTextBox.Clear();

                subOptionLabel.Text = "You decide not to press the button.";

                locationLabel.Text = "Window";
            }
            else if (userInput == "rc")
            {
                choiceTextBox.Clear();

                ExamineRightCurtain();
            }
            else if (userInput == "b" && locationLabel.Text == "Room")
            {
                choiceTextBox.Clear();

                locationLabel.Text = "Bed";

                GoToBed();

            }
            else if (userInput == "gb")
            {
                choiceTextBox.Clear();

                GoBack();
            }
            else
            {
                choiceTextBox.Clear();

                subOptionLabel.Text = $"{userInput} is not valid. Please enter your choice from the options, ensuring it is spelt correctly.";
            }
        }

        void CabinetOptions()
        {
            List<string> cabinetChoice = new List<string>
            {
                    "Top drawer(td)",
                    "Middle drawer(md)",
                    "Bottom drawer(bd)",
                    "Box(b)",
                    "Go back(gb)"
            };

            locationLabel.Text = "Cabinet";

            mainLabel.Text = "You walk to the Cabinet.\n" +
                             "...\n" +
                             "You see a small cabinet made out of a smooth wood.\n" +
                             "It contains three drawers.\n" +
                             "A cylindrical box sits on top of the cabinet.\n" +
                             "...\n" +
                             "Please enter your choice from the options below into the text box and press enter:\n" +
                             "(e.g. td for Top Drawer)\n\n";

            for (int i = 0; i < cabinetChoice.Count; i++)
            {
                mainLabel.Text += $"- {cabinetChoice[i]}\n";
            }

        }

        void OpenTopDrawer()
        {
            playerOne.health -= 100;
            CheckHealth();
        }

        void OpenMiddleDrawer()
        {
            if (!inventory.Contains(orangeJewel))
            {
                if (inventory.Contains(bronzeKey))
                {
                    subOptionLabel.Text = "You use the Bronze Key to unlock the Middle Drawer\n" +
                                          "You find a Orange Jewel.\n" +
                                          "A Orange Jewel has been added to your inventory.";

                    inventory.Add(orangeJewel);
                    inventoryListBox.Items.Add(orangeJewel.name);

                }
                else
                {
                    subOptionLabel.Text = "You try to open the Middle Drawer.\n" +
                                          "It is locked.";
                }
            }
            else
            {
                subOptionLabel.Text = "You open the Middle Drawer.\n" +
                                      "It is empty.";
            }
        }

        void OpenBottomDrawer()
        {
            if (!inventory.Contains(redCoin) && !inventory.Contains(torch))
            {
                subOptionLabel.Text = "You open the Bottom Drawer.\n" +
                                      "You find a Red Coin.\n" +
                                      "A Red Coin has been added to your inventory.\n" +
                                      "You find a Torch.\n" +
                                      "A Torch has been added to your inventory.\n";

                inventory.Add(redCoin);
                inventory.Add(torch);

                inventoryListBox.Items.Add(redCoin.name);
                inventoryListBox.Items.Add(torch.name);
            }
            else
            {
                subOptionLabel.Text = "You open the Bottom Drawer.\n" +
                                      "It is empty";
            }
        }

        void PickUpBox()
        {
            if (fortuneTold)
            {
                playerOne.energy -= 100;
                CheckEnergy();
            }
            else
            {
                subOptionLabel.Text = "You pick up the Box on top of the cabinet.\n" +
                                      "It is mostly white, lined with red swirls.\n" +
                                      "You shake it and hear paper rustling inside.\n" +
                                      "A paper slip falls out.\n" +
                                      "...";

                Random random = new Random();
                int fortune = random.Next(1, 100);

                int greatFortune = 80;
                int goodFortune = 70;
                int misfortune = 40;
                int greatMisfortune = 10;

                if (fortune <= greatMisfortune)
                {
                    subOptionLabel.Text = $"{subOptionLabel.Text}\nThe paper slip reads: Great Misfortune\n" +
                                          "A Great Misfortune Slip has been added to your inventory.\n" +
                                          "Your energy has decreased by 50";

                    playerOne.energy -= 50;
                    CheckEnergy();

                    Inventory greatMisfortuneSlip = new Inventory();

                    greatMisfortuneSlip.name = "Great Misfortune Slip";
                    greatMisfortuneSlip.description = "A fortune slip. It reads Great Misfortune.";
                    greatMisfortuneSlip.rarity = "Rare";
                    greatMisfortuneSlip.locationFound = "Fortune Box";

                    inventory.Add(greatMisfortuneSlip);
                    inventoryListBox.Items.Add(greatMisfortuneSlip.name);

                }
                else if (fortune <= misfortune)
                {
                    subOptionLabel.Text = $"{subOptionLabel.Text}\nThe paper slip reads: Misfortune\n" +
                                          "A Misfortune Slip has been added to your inventory.\n" +
                                          "Your energy has decreased by 30.";

                    playerOne.energy -= 30;
                    CheckEnergy();

                    Inventory misfortuneSlip = new Inventory();

                    misfortuneSlip.name = "Misfortune Slip";
                    misfortuneSlip.description = "A fortune slip. It reads Misfortune.";
                    misfortuneSlip.rarity = "Common";
                    misfortuneSlip.locationFound = "Fortune Box";

                    inventory.Add(misfortuneSlip);
                    inventoryListBox.Items.Add(misfortuneSlip.name);
                }
                else if (fortune <= goodFortune)
                {
                    subOptionLabel.Text = $"{subOptionLabel.Text}\nThe paper slip reads: Good Fortune\n" +
                                          "A Good Fortune Slip has been added to your inventory.";

                    Inventory goodFortuneSlip = new Inventory();

                    goodFortuneSlip.name = "Good Fortune Slip";
                    goodFortuneSlip.description = "A fortune slip. It reads Good Fortune.";
                    goodFortuneSlip.rarity = "Common";
                    goodFortuneSlip.locationFound = "Fortune Box";

                    inventory.Add(goodFortuneSlip);
                    inventoryListBox.Items.Add(goodFortuneSlip.name);
                }
                else if (fortune <= greatFortune)
                {
                    subOptionLabel.Text = $"{subOptionLabel.Text}\nThe paper slip reads: Great Fortune\n" +
                                          "A Great Fortune Slip has been added to your inventory.";

                    Inventory greatFortuneSlip = new Inventory();

                    greatFortuneSlip.name = "Great Fortune Slip";
                    greatFortuneSlip.description = "A fortune slip. It reads Great Fortune.";
                    greatFortuneSlip.rarity = "Rare";
                    greatFortuneSlip.locationFound = "Fortune Box";

                    inventory.Add(greatFortuneSlip);
                    inventoryListBox.Items.Add(greatFortuneSlip.name);
                }
                else
                {
                    subOptionLabel.Text = $"{subOptionLabel.Text}\nThe paper slip is empty.\n" +
                                          "An Empty Paper Slip has been added to your inventory.";

                    Inventory emptyPaperSlip = new Inventory();

                    emptyPaperSlip.name = "Empty Paper Slip";
                    emptyPaperSlip.description = "A fortune slip. It is empty.";
                    emptyPaperSlip.rarity = "Common";
                    emptyPaperSlip.locationFound = "Fortune Box";

                    inventory.Add(emptyPaperSlip);
                    inventoryListBox.Items.Add(emptyPaperSlip.name);
                }

                fortuneTold = true;
            }
        }

        void WindowOptions()
        {
            List<string> windowChoice = new List<string>
            {
                "Padlock(pa)",
                "Picture(pi)",
                "Left curtain(lc)",
                "Right curtain(rc)",
                "Go back(gb)",
            };

            locationLabel.Text = "Window";

            mainLabel.Text = "You walk to the Window.\n" +
                             "...\n" +
                             "You see a single window with thick blue curtains draped at either side.\n" +
                             "It is locked by a padlock and the outside is barricaded with grey bars.\n" +
                             "A picture frame lies to the left of the windowsill.\n" +
                             "...\n" +
                             "Please enter your choice from the options below into the text box and press enter:\n" +
                             "(e.g. pa for padlock)\n\n"; ;

            for (int i = 0; i < windowChoice.Count; i++)
            {
                mainLabel.Text += $"- {windowChoice[i]}\n";
            }
        }

        void TryPadlock()
        {
            padlockForm padlockForm = new padlockForm(this, padlockCodeOne, padlockCodeTwo, padlockCodeThree);

            padlockForm.Show();
        }
        //reference: https://stackoverflow.com/questions/6666368/c-how-to-hide-one-form-and-show-another
        //reference: https://stackoverflow.com/questions/1173973/passing-variables-into-another-form#:~:text=An%20easy%20way%20is%20to%20use%20properties.%20The,1%3B%20form2.ShowDialog%20%28%29%3B%20or%20something%20along%20those%20lines.

        public void UnlockedPadlock() //reference: https://stackoverflow.com/questions/31302825/inaccessible-due-to-its-protection-level
        {
            if (!inventory.Contains(bronzeKey))
            {
                if (inventory.Contains(torch))
                {
                    subOptionLabel.Text = "The padlock unlocks with a clicking sound.\n" +
                                          "You pull the window open.\n" +
                                          "You shine your torch outside the window.\n" +
                                          "A bronze key on the window ledge comes into view.\n" +
                                          "A Bronze Key has been added to your inventory.\n" +
                                          "As soon as you take the bronze key, the window closes and the padlock clicks shut.\n" +
                                          "A blue rune shines in front before slowly fading away.";

                    inventory.Add(bronzeKey);
                    inventoryListBox.Items.Add(bronzeKey.name);

                }
                else
                {
                    subOptionLabel.Text = "The padlock unlocks with a clicking sound.\n" +
                                          "You pull the window open.\n" +
                                          "It is too dark to see outside.\n" +
                                          "Maybe a source of light would help.\n" +
                                          "As soon as you take a step back from the window, it closes and the padlock clicks shut.\n" +
                                          "A blue rune shines in front before slowly fading away.";
                }
            }
            else
            {
                subOptionLabel.Text = "The padlock unlocks with a clicking sound and you pull the window open.\n" +
                                      "It is too dark outside and you do not know how high up you are.\n" +
                                      "It is too risky to escape this way.";
            }
        }

        void ExaminePictureFrame()
        {
            if (!inventory.Contains(goldenBell))
            {
                subOptionLabel.Text = "You pick up the Picture.\n" +
                                      "It is of a girl and a boy, who look like twin siblings, playing with an orange tabby cat.\n" +
                                      "The edges of the frame are worn smooth, and the glass covering the picture is clear and free of dust.\n" +
                                      "It is clear that whoever owned this picture treasured it immensely.\n" +
                                      "You turn the picture frame over.\n" +
                                     $"3 numbers are written neatly in the corner: {padlockCodeOne}{padlockCodeTwo}{padlockCodeThree}\n" +
                                      "You also find a golden bell hanging on a hook.\n" +
                                      "A Golden Bell has been added to your inventory.";

                inventory.Add(goldenBell);
                inventoryListBox.Items.Add(goldenBell.name);

            }
            else
            {
                subOptionLabel.Text = "You pick up the Picture.\n" +
                                      "You turn the picture frame over.\n" +
                                      $"3 numbers are written neatly in the corner: {padlockCodeOne}{padlockCodeTwo}{padlockCodeThree}";
            }
        }

        void ExamineLeftCurtain()
        {
            locationLabel.Text = "Left Curtain";

            if (!arcadePuzzleSolved)
            {
                subOptionLabel.Text = "You examine the Left Curtain.\n" +
                                      "Behind it, you find a little arcade machine.\n" +
                                      "There is a coin slot and a button which says START.\n" +
                                      "Would you like to insert a coin and press the button?\n" +
                                      "Please enter your choice (Yes or No) into the text box and press enter:";
            }
            else
            {
                subOptionLabel.Text = "You have already solved the arcade puzzle.";
            }
        }

        public void SolvedArcadePuzzle()
        {
            locationLabel.Text = "Window";

            subOptionLabel.Text = "The arcade machine lets out a ding!\n" +
                         "A small compartment embedded in the machine whirrs open.\n" +
                         "It contains a blue jewel.\n" +
                         "A Blue Jewel has been added to your inventory.\n" +
                         "It also contains the red coin you inserted so you take it back.";

            inventory.Add(blueJewel);
            inventoryListBox.Items.Add(blueJewel.name);

            arcadePuzzleSolved = true;
        }

        void ExamineRightCurtain()
        {
            if (!inventory.Contains(blackJewel))
            {
                subOptionLabel.Text = "You examine the Right Curtain.\n" +
                                      "A black jewel sits on the windowsill.\n" +
                                      "A Black Jewel has been added to your inventory.";

                inventory.Add(blackJewel);
                inventoryListBox.Items.Add(blackJewel.name);
            }
            else
            {
                subOptionLabel.Text = "You examine the Right Curtain.\n" +
                                      "The windowsill is empty.";
            }
        }

        private void GoToBed()
        {
            if (inventory.Contains(blackJewel) && inventory.Contains(blueJewel) && inventory.Contains(orangeJewel))
            {
                mainLabel.Text = "You walk over to the bed.\n" +
                                 "It is tidy and neatly made.\n" +
                                 "Your foot bumps against something and you notice a edge of a box poking out from under the bed.\n" +
                                 "You pull the box out and open it.\n" +
                                 "The 3 jewels you have start glowing.\n" +
                                 "A rune writes itself in the air on its way to the door.\n" +
                                 "You close your eyes against the bright flash of light.\n" +
                                 "You open your eyes again, and you see that the door is finally open.";

                MessageBox.Show("You have successfully escaped!");

                this.Close();
            }
            else
            {
                mainLabel.Text = "You walk over to the bed.\n" +
                                 "It is tidy and neatly made.\n" +
                                 "Your foot bumps against something and you notice a edge of a box poking out from under the bed.\n" +
                                 "You open it and see 3 slots.\n" +
                                 "You need to collect all 3 jewels before doing anything with this box.\n" +
                                 "(To go back, enter gb in the textbox and press enter.)";
            }

            if (!inventory.Contains(extractOfText))
            {
                CollectExtract();
            }
        }

        private void CollectExtract()
        {
            string path = "runes.txt";

            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);

                subOptionLabel.Text = "You find a piece of paper tucked neatly under the pillow.\n" +
                                      $"The title catches your eye: {text}\n" +
                                      "But you scan through it and see nothing of importance.";

                inventory.Add(extractOfText);
                inventoryListBox.Items.Add(extractOfText.name);
            }
            else
            {
                subOptionLabel.Text = "You find a piece of paper tucked neatly under the pillow.\n" +
                                      "As soon as you touch it, it crumbles to ashes.";
            }
        }

        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                int selectedIndex = inventoryListBox.SelectedIndex;

                if (selectedIndex >= 0 && selectedIndex < inventory.Count)
                {
                    var selectedItem = inventory[selectedIndex];

                    subOptionLabel.Text = $"Description: {selectedItem.description}\n" +
                                          $"Rarity: {selectedItem.rarity}\n" +
                                          $"Location found: {selectedItem.locationFound}";
                }
            }
        }



        void UserStats()
        {
            Debug.Assert(playerOne.health! > -1 && playerOne.health! < 101);
            Debug.Assert(playerOne.energy! > -1 && playerOne.energy! < 101);

            healthLabel.Text = $"Health = {playerOne.health}";
            energyLabel.Text = $"Energy = {playerOne.energy}";
        }

        void GoBack()
        {
            List<string> choice = new List<string>();
            {
                choice.Add("Cabinet(c)");
                choice.Add("Bed(b)");
                choice.Add("Window(w)");
            }

            locationLabel.Text = "Room";

            mainLabel.Text = "Your task is to escape the room.\n" +
                              "Please enter your choice from the options below into the text box and press enter:\n" +
                              "(e.g. c for Cabinet)\n\n";

            for (int i = 0; i < choice.Count; i++)
            {
                mainLabel.Text += $"- {choice[i]}\n";
            }

            subOptionLabel.Text = "";
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            tutorialForm.Show();
            tutorialForm.DisplayTutorialPageOne();
        }

        private void CheckHealth()
        {
            UserStats();

            if (playerOne.health <= 0)
            {
                mainLabel.Text = "You open the top drawer.\n" +
                                 "A red rune shines on the bottom.\n" +
                                 "You feel your health draining away from you.\n" +
                                 "Your health has reached 0.";

                if (inventory.Contains(goldenBell))
                {
                    subOptionLabel.Text = "The ringing of bells echoes in your mind.\n" +
                                          "You slowly start to feel better because of the soft chimes.\n" +
                                          "Your health has risen back up to 100.\n" +
                                          "To go back to options, enter gb in the textbox and press enter.";
                    playerOne.health = 100;
                }
                else
                {
                    AfterFail();
                }
            }
        }

        private void CheckEnergy()
        {
            UserStats();

            if (playerOne.energy <= 0)
            {
                mainLabel.Text = "You hear a reprimanding voice in your head that keeps saying the same thing over and over:\n" +
                                 "You have already had your fortune told today!\n" +
                                 "The voice is unceasing and so you feel your energy draining away.\n" +
                                 "Your energy has reached 0.";

                if (inventory.Contains(goldenBell))
                {
                    subOptionLabel.Text = "The ringing of bells echoes in your mind.\n" +
                                          "You slowly start to feel better because of the soft chimes.\n" +
                                          "Your energy has risen back up to 100.\n" +
                                          "To go back to options, enter gb in the textbox and press enter.";

                    playerOne.energy = 100;
                }
                else
                {
                    AfterFail();
                }
            }
        }

        private void AfterFail()
        {
            MessageBox.Show("GAME OVER: A stat has reached 0.");
            this.Close();
        }
    }
}

//images in pictureboxes from https://opengameart.org/

