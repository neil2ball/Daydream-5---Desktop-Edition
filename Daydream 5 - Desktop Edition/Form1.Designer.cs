namespace Daydream_5___Desktop_Edition
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            getHelpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            sortedCheckBox = new CheckBox();
            pickLimit = new NumericUpDown();
            pickLimitLabel = new Label();
            drawTimeGroupBox = new GroupBox();
            bothDrawTimeButton = new RadioButton();
            eveningDrawTimeButton = new RadioButton();
            middayDrawTimeButton = new RadioButton();
            noDrawTimeButton = new RadioButton();
            ezMatchCheckBox = new CheckBox();
            advancePlayComboBox = new ComboBox();
            picksPerPlayslip = new NumericUpDown();
            picksPerPlayslipLabel = new Label();
            PickListLabel = new Label();
            pickCountLabel = new Label();
            getPicksButton = new Button();
            folderPathTextBox = new TextBox();
            selectFolderButton = new Button();
            printPicksButton = new Button();
            folderLocationLabel = new Label();
            picksRichTextBox = new RichTextBox();
            pickCountRichTextBox = new RichTextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pickLimit).BeginInit();
            drawTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picksPerPlayslip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(624, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getHelpToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // getHelpToolStripMenuItem
            // 
            getHelpToolStripMenuItem.Name = "getHelpToolStripMenuItem";
            getHelpToolStripMenuItem.Size = new Size(180, 22);
            getHelpToolStripMenuItem.Text = "Get help";
            getHelpToolStripMenuItem.Click += getHelpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // sortedCheckBox
            // 
            sortedCheckBox.AutoSize = true;
            sortedCheckBox.Checked = true;
            sortedCheckBox.CheckState = CheckState.Checked;
            sortedCheckBox.Location = new Point(24, 97);
            sortedCheckBox.Name = "sortedCheckBox";
            sortedCheckBox.Size = new Size(180, 19);
            sortedCheckBox.TabIndex = 3;
            sortedCheckBox.Text = "Sort picks in numerical order.";
            sortedCheckBox.UseVisualStyleBackColor = true;
            // 
            // pickLimit
            // 
            pickLimit.Location = new Point(24, 68);
            pickLimit.Maximum = new decimal(new int[] { 252, 0, 0, 0 });
            pickLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pickLimit.Name = "pickLimit";
            pickLimit.Size = new Size(52, 23);
            pickLimit.TabIndex = 4;
            pickLimit.TextAlign = HorizontalAlignment.Right;
            pickLimit.Value = new decimal(new int[] { 252, 0, 0, 0 });
            // 
            // pickLimitLabel
            // 
            pickLimitLabel.AutoSize = true;
            pickLimitLabel.Location = new Point(82, 70);
            pickLimitLabel.Name = "pickLimitLabel";
            pickLimitLabel.Size = new Size(56, 15);
            pickLimitLabel.TabIndex = 5;
            pickLimitLabel.Text = "Pick limit";
            // 
            // drawTimeGroupBox
            // 
            drawTimeGroupBox.Controls.Add(bothDrawTimeButton);
            drawTimeGroupBox.Controls.Add(eveningDrawTimeButton);
            drawTimeGroupBox.Controls.Add(middayDrawTimeButton);
            drawTimeGroupBox.Controls.Add(noDrawTimeButton);
            drawTimeGroupBox.Location = new Point(24, 200);
            drawTimeGroupBox.Name = "drawTimeGroupBox";
            drawTimeGroupBox.Size = new Size(200, 107);
            drawTimeGroupBox.TabIndex = 6;
            drawTimeGroupBox.TabStop = false;
            drawTimeGroupBox.Text = "Draw time";
            // 
            // bothDrawTimeButton
            // 
            bothDrawTimeButton.AutoSize = true;
            bothDrawTimeButton.Location = new Point(7, 82);
            bothDrawTimeButton.Name = "bothDrawTimeButton";
            bothDrawTimeButton.Size = new Size(50, 19);
            bothDrawTimeButton.TabIndex = 3;
            bothDrawTimeButton.Text = "Both";
            bothDrawTimeButton.UseVisualStyleBackColor = true;
            // 
            // eveningDrawTimeButton
            // 
            eveningDrawTimeButton.AutoSize = true;
            eveningDrawTimeButton.Location = new Point(7, 61);
            eveningDrawTimeButton.Name = "eveningDrawTimeButton";
            eveningDrawTimeButton.Size = new Size(67, 19);
            eveningDrawTimeButton.TabIndex = 2;
            eveningDrawTimeButton.Text = "Evening";
            eveningDrawTimeButton.UseVisualStyleBackColor = true;
            // 
            // middayDrawTimeButton
            // 
            middayDrawTimeButton.AutoSize = true;
            middayDrawTimeButton.Location = new Point(7, 42);
            middayDrawTimeButton.Name = "middayDrawTimeButton";
            middayDrawTimeButton.Size = new Size(65, 19);
            middayDrawTimeButton.TabIndex = 1;
            middayDrawTimeButton.Text = "Midday";
            middayDrawTimeButton.UseVisualStyleBackColor = true;
            // 
            // noDrawTimeButton
            // 
            noDrawTimeButton.AutoSize = true;
            noDrawTimeButton.Checked = true;
            noDrawTimeButton.Location = new Point(7, 22);
            noDrawTimeButton.Name = "noDrawTimeButton";
            noDrawTimeButton.Size = new Size(121, 19);
            noDrawTimeButton.TabIndex = 0;
            noDrawTimeButton.TabStop = true;
            noDrawTimeButton.Text = "Nearest draw time";
            noDrawTimeButton.UseVisualStyleBackColor = true;
            // 
            // ezMatchCheckBox
            // 
            ezMatchCheckBox.AutoSize = true;
            ezMatchCheckBox.Location = new Point(23, 323);
            ezMatchCheckBox.Name = "ezMatchCheckBox";
            ezMatchCheckBox.Size = new Size(73, 19);
            ezMatchCheckBox.TabIndex = 7;
            ezMatchCheckBox.Text = "EZmatch";
            ezMatchCheckBox.UseVisualStyleBackColor = true;
            // 
            // advancePlayComboBox
            // 
            advancePlayComboBox.FormattingEnabled = true;
            advancePlayComboBox.Items.AddRange(new object[] { "2", "3", "4", "5", "7", "10", "14", "21", "28", "30" });
            advancePlayComboBox.Location = new Point(23, 358);
            advancePlayComboBox.Name = "advancePlayComboBox";
            advancePlayComboBox.Size = new Size(121, 23);
            advancePlayComboBox.TabIndex = 8;
            advancePlayComboBox.Text = "Advance Play";
            // 
            // picksPerPlayslip
            // 
            picksPerPlayslip.Location = new Point(23, 403);
            picksPerPlayslip.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            picksPerPlayslip.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            picksPerPlayslip.Name = "picksPerPlayslip";
            picksPerPlayslip.Size = new Size(53, 23);
            picksPerPlayslip.TabIndex = 9;
            picksPerPlayslip.TextAlign = HorizontalAlignment.Right;
            picksPerPlayslip.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // picksPerPlayslipLabel
            // 
            picksPerPlayslipLabel.AutoSize = true;
            picksPerPlayslipLabel.Location = new Point(82, 405);
            picksPerPlayslipLabel.Name = "picksPerPlayslipLabel";
            picksPerPlayslipLabel.Size = new Size(97, 15);
            picksPerPlayslipLabel.TabIndex = 10;
            picksPerPlayslipLabel.Text = "Picks per playslip";
            // 
            // PickListLabel
            // 
            PickListLabel.AutoSize = true;
            PickListLabel.Location = new Point(408, 38);
            PickListLabel.Name = "PickListLabel";
            PickListLabel.Size = new Size(47, 15);
            PickListLabel.TabIndex = 11;
            PickListLabel.Text = "Pick list";
            // 
            // pickCountLabel
            // 
            pickCountLabel.AutoSize = true;
            pickCountLabel.Location = new Point(507, 38);
            pickCountLabel.Name = "pickCountLabel";
            pickCountLabel.Size = new Size(85, 15);
            pickCountLabel.TabIndex = 12;
            pickCountLabel.Text = "Number count";
            // 
            // getPicksButton
            // 
            getPicksButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getPicksButton.Location = new Point(24, 122);
            getPicksButton.Name = "getPicksButton";
            getPicksButton.Size = new Size(86, 28);
            getPicksButton.TabIndex = 13;
            getPicksButton.Text = "Get picks";
            getPicksButton.UseMnemonic = false;
            getPicksButton.UseVisualStyleBackColor = true;
            getPicksButton.Click += getPicksButton_Click;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.BackColor = SystemColors.ControlLightLight;
            folderPathTextBox.Location = new Point(23, 462);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.ReadOnly = true;
            folderPathTextBox.Size = new Size(234, 23);
            folderPathTextBox.TabIndex = 14;
            folderPathTextBox.Text = "C:\\Daydream5";
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(263, 462);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(87, 23);
            selectFolderButton.TabIndex = 15;
            selectFolderButton.Text = "Select Folder";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // printPicksButton
            // 
            printPicksButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printPicksButton.Location = new Point(23, 505);
            printPicksButton.Name = "printPicksButton";
            printPicksButton.Size = new Size(86, 31);
            printPicksButton.TabIndex = 16;
            printPicksButton.Text = "Print picks";
            printPicksButton.UseVisualStyleBackColor = true;
            printPicksButton.Click += printPicksButton_Click;
            // 
            // folderLocationLabel
            // 
            folderLocationLabel.AutoSize = true;
            folderLocationLabel.Location = new Point(23, 444);
            folderLocationLabel.Name = "folderLocationLabel";
            folderLocationLabel.Size = new Size(145, 15);
            folderLocationLabel.TabIndex = 17;
            folderLocationLabel.Text = "Select a folder to save files";
            // 
            // picksRichTextBox
            // 
            picksRichTextBox.BackColor = SystemColors.ControlLightLight;
            picksRichTextBox.Location = new Point(383, 56);
            picksRichTextBox.Name = "picksRichTextBox";
            picksRichTextBox.ReadOnly = true;
            picksRichTextBox.Size = new Size(99, 548);
            picksRichTextBox.TabIndex = 18;
            picksRichTextBox.Text = "";
            // 
            // pickCountRichTextBox
            // 
            pickCountRichTextBox.BackColor = SystemColors.ControlLightLight;
            pickCountRichTextBox.Location = new Point(524, 56);
            pickCountRichTextBox.Name = "pickCountRichTextBox";
            pickCountRichTextBox.ReadOnly = true;
            pickCountRichTextBox.Size = new Size(55, 548);
            pickCountRichTextBox.TabIndex = 19;
            pickCountRichTextBox.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(151, 635);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(461, 82);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 589);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 729);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(pickCountRichTextBox);
            Controls.Add(picksRichTextBox);
            Controls.Add(folderLocationLabel);
            Controls.Add(printPicksButton);
            Controls.Add(selectFolderButton);
            Controls.Add(folderPathTextBox);
            Controls.Add(getPicksButton);
            Controls.Add(pickCountLabel);
            Controls.Add(PickListLabel);
            Controls.Add(picksPerPlayslipLabel);
            Controls.Add(picksPerPlayslip);
            Controls.Add(advancePlayComboBox);
            Controls.Add(ezMatchCheckBox);
            Controls.Add(drawTimeGroupBox);
            Controls.Add(pickLimitLabel);
            Controls.Add(pickLimit);
            Controls.Add(sortedCheckBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Daydream 5 - Desktop Edition";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pickLimit).EndInit();
            drawTimeGroupBox.ResumeLayout(false);
            drawTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picksPerPlayslip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private CheckBox sortedCheckBox;
        private NumericUpDown pickLimit;
        private Label pickLimitLabel;
        private GroupBox drawTimeGroupBox;
        private RadioButton bothDrawTimeButton;
        private RadioButton eveningDrawTimeButton;
        private RadioButton middayDrawTimeButton;
        private RadioButton noDrawTimeButton;
        private CheckBox ezMatchCheckBox;
        private ComboBox advancePlayComboBox;
        private NumericUpDown picksPerPlayslip;
        private Label picksPerPlayslipLabel;
        private Label PickListLabel;
        private Label pickCountLabel;
        private Button getPicksButton;
        private TextBox folderPathTextBox;
        private Button selectFolderButton;
        private Button printPicksButton;
        private Label folderLocationLabel;
        private RichTextBox picksRichTextBox;
        private RichTextBox pickCountRichTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem getHelpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
