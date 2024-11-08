namespace ProgrammingCourseworkGUI
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainLabel = new Label();
            choiceTextBox = new TextBox();
            enterButton = new Button();
            locationLabel = new Label();
            inventoryListBox = new ListBox();
            tutorialButton = new Button();
            choiceLabel = new Label();
            subOptionLabel = new Label();
            healthLabel = new Label();
            energyLabel = new Label();
            inventoryLabel = new Label();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.BackColor = SystemColors.InactiveCaption;
            mainLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.Location = new Point(237, 68);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(52, 28);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "        ";
            // 
            // choiceTextBox
            // 
            choiceTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            choiceTextBox.Location = new Point(54, 124);
            choiceTextBox.Name = "choiceTextBox";
            choiceTextBox.Size = new Size(125, 32);
            choiceTextBox.TabIndex = 1;
            // 
            // enterButton
            // 
            enterButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            enterButton.Location = new Point(69, 172);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(94, 45);
            enterButton.TabIndex = 2;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(12, 9);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(69, 20);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location:";
            // 
            // inventoryListBox
            // 
            inventoryListBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 25;
            inventoryListBox.Location = new Point(1305, 131);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(396, 254);
            inventoryListBox.TabIndex = 7;
            // 
            // tutorialButton
            // 
            tutorialButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tutorialButton.Location = new Point(1460, 715);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(175, 41);
            tutorialButton.TabIndex = 11;
            tutorialButton.Text = "Tutorial";
            tutorialButton.UseVisualStyleBackColor = true;
            tutorialButton.Click += tutorialButton_Click;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = SystemColors.Info;
            choiceLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            choiceLabel.Location = new Point(54, 68);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(128, 30);
            choiceLabel.TabIndex = 13;
            choiceLabel.Text = "Your Choice";
            // 
            // subOptionLabel
            // 
            subOptionLabel.AutoSize = true;
            subOptionLabel.BackColor = SystemColors.InactiveCaption;
            subOptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subOptionLabel.Location = new Point(232, 492);
            subOptionLabel.Name = "subOptionLabel";
            subOptionLabel.Size = new Size(57, 28);
            subOptionLabel.TabIndex = 14;
            subOptionLabel.Text = "         ";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.BackColor = Color.LightCoral;
            healthLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            healthLabel.Location = new Point(1504, 518);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(57, 25);
            healthLabel.TabIndex = 18;
            healthLabel.Text = "         ";
            // 
            // energyLabel
            // 
            energyLabel.AutoSize = true;
            energyLabel.BackColor = Color.Gold;
            energyLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            energyLabel.Location = new Point(1504, 608);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new Size(57, 25);
            energyLabel.TabIndex = 19;
            energyLabel.Text = "         ";
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.BackColor = Color.LightGreen;
            inventoryLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryLabel.Location = new Point(1398, 50);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(237, 46);
            inventoryLabel.TabIndex = 21;
            inventoryLabel.Text = "Your Inventory";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 780);
            Controls.Add(inventoryLabel);
            Controls.Add(energyLabel);
            Controls.Add(healthLabel);
            Controls.Add(subOptionLabel);
            Controls.Add(choiceLabel);
            Controls.Add(tutorialButton);
            Controls.Add(inventoryListBox);
            Controls.Add(locationLabel);
            Controls.Add(enterButton);
            Controls.Add(choiceTextBox);
            Controls.Add(mainLabel);
            Name = "mainForm";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mainLabel;
        private TextBox choiceTextBox;
        private Button enterButton;
        private Label locationLabel;
        private ListBox inventoryListBox;
        private Button tutorialButton;
        private Label choiceLabel;
        private Label subOptionLabel;
        private Label healthLabel;
        private Label energyLabel;
        private Label inventoryLabel;
    }
}