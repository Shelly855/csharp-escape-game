namespace ProgrammingCourseworkGUI
{
    partial class padlockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            windowPadlockNo1 = new Label();
            windowPadlockNo2 = new Label();
            windowPadlockNo3 = new Label();
            windowPadlockNo1Left = new Button();
            windowPadlockNo2Left = new Button();
            windowPadlockNo3Left = new Button();
            windowPadlockNo1Right = new Button();
            windowPadlockNo2Right = new Button();
            windowPadlockNo3Right = new Button();
            padlockLabel = new Label();
            SuspendLayout();
            // 
            // windowPadlockNo1
            // 
            windowPadlockNo1.AutoSize = true;
            windowPadlockNo1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo1.Location = new Point(354, 113);
            windowPadlockNo1.Name = "windowPadlockNo1";
            windowPadlockNo1.Size = new Size(74, 89);
            windowPadlockNo1.TabIndex = 0;
            windowPadlockNo1.Text = "0";
            // 
            // windowPadlockNo2
            // 
            windowPadlockNo2.AutoSize = true;
            windowPadlockNo2.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo2.Location = new Point(354, 205);
            windowPadlockNo2.Name = "windowPadlockNo2";
            windowPadlockNo2.Size = new Size(74, 89);
            windowPadlockNo2.TabIndex = 1;
            windowPadlockNo2.Text = "0";
            // 
            // windowPadlockNo3
            // 
            windowPadlockNo3.AutoSize = true;
            windowPadlockNo3.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo3.Location = new Point(354, 313);
            windowPadlockNo3.Name = "windowPadlockNo3";
            windowPadlockNo3.Size = new Size(74, 89);
            windowPadlockNo3.TabIndex = 2;
            windowPadlockNo3.Text = "0";
            // 
            // windowPadlockNo1Left
            // 
            windowPadlockNo1Left.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo1Left.Location = new Point(300, 130);
            windowPadlockNo1Left.Name = "windowPadlockNo1Left";
            windowPadlockNo1Left.Size = new Size(48, 58);
            windowPadlockNo1Left.TabIndex = 3;
            windowPadlockNo1Left.Text = "<";
            windowPadlockNo1Left.UseVisualStyleBackColor = true;
            windowPadlockNo1Left.Click += windowPadlockNo1Left_Click;
            // 
            // windowPadlockNo2Left
            // 
            windowPadlockNo2Left.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo2Left.Location = new Point(300, 224);
            windowPadlockNo2Left.Name = "windowPadlockNo2Left";
            windowPadlockNo2Left.Size = new Size(48, 58);
            windowPadlockNo2Left.TabIndex = 4;
            windowPadlockNo2Left.Text = "<";
            windowPadlockNo2Left.UseVisualStyleBackColor = true;
            windowPadlockNo2Left.Click += windowPadlockNo2Left_Click;
            // 
            // windowPadlockNo3Left
            // 
            windowPadlockNo3Left.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo3Left.Location = new Point(300, 327);
            windowPadlockNo3Left.Name = "windowPadlockNo3Left";
            windowPadlockNo3Left.Size = new Size(48, 58);
            windowPadlockNo3Left.TabIndex = 5;
            windowPadlockNo3Left.Text = "<";
            windowPadlockNo3Left.UseVisualStyleBackColor = true;
            windowPadlockNo3Left.Click += windowPadlockNo3Left_Click;
            // 
            // windowPadlockNo1Right
            // 
            windowPadlockNo1Right.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo1Right.Location = new Point(425, 130);
            windowPadlockNo1Right.Name = "windowPadlockNo1Right";
            windowPadlockNo1Right.Size = new Size(48, 58);
            windowPadlockNo1Right.TabIndex = 6;
            windowPadlockNo1Right.Text = ">";
            windowPadlockNo1Right.UseVisualStyleBackColor = true;
            windowPadlockNo1Right.Click += windowPadlockNo1Right_Click;
            // 
            // windowPadlockNo2Right
            // 
            windowPadlockNo2Right.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo2Right.Location = new Point(425, 224);
            windowPadlockNo2Right.Name = "windowPadlockNo2Right";
            windowPadlockNo2Right.Size = new Size(48, 58);
            windowPadlockNo2Right.TabIndex = 7;
            windowPadlockNo2Right.Text = ">";
            windowPadlockNo2Right.UseVisualStyleBackColor = true;
            windowPadlockNo2Right.Click += windowPadlockNo2Right_Click;
            // 
            // windowPadlockNo3Right
            // 
            windowPadlockNo3Right.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            windowPadlockNo3Right.Location = new Point(425, 327);
            windowPadlockNo3Right.Name = "windowPadlockNo3Right";
            windowPadlockNo3Right.Size = new Size(48, 58);
            windowPadlockNo3Right.TabIndex = 8;
            windowPadlockNo3Right.Text = ">";
            windowPadlockNo3Right.UseVisualStyleBackColor = true;
            windowPadlockNo3Right.Click += windowPadlockNo3Right_Click;
            // 
            // padlockLabel
            // 
            padlockLabel.AutoSize = true;
            padlockLabel.BackColor = SystemColors.InactiveCaption;
            padlockLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            padlockLabel.Location = new Point(27, 56);
            padlockLabel.Name = "padlockLabel";
            padlockLabel.Size = new Size(60, 23);
            padlockLabel.TabIndex = 9;
            padlockLabel.Text = "          ";
            // 
            // padlockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(padlockLabel);
            Controls.Add(windowPadlockNo3Right);
            Controls.Add(windowPadlockNo2Right);
            Controls.Add(windowPadlockNo1Right);
            Controls.Add(windowPadlockNo3Left);
            Controls.Add(windowPadlockNo2Left);
            Controls.Add(windowPadlockNo1Left);
            Controls.Add(windowPadlockNo3);
            Controls.Add(windowPadlockNo2);
            Controls.Add(windowPadlockNo1);
            Name = "padlockForm";
            Text = "Padlock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label windowPadlockNo1;
        private Label windowPadlockNo2;
        private Label windowPadlockNo3;
        private Button windowPadlockNo1Left;
        private Button windowPadlockNo2Left;
        private Button windowPadlockNo3Left;
        private Button windowPadlockNo1Right;
        private Button windowPadlockNo2Right;
        private Button windowPadlockNo3Right;
        private Label padlockLabel;
    }
}