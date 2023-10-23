namespace VampireSurvivorsSaveSync
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            txtSteam = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAndroid = new TextBox();
            btnChooseSteamSave = new Button();
            btnChooseAndroidSave = new Button();
            btnSyncSteamAndroid = new Button();
            btnSyncAndroidSteam = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(452, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(98, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(98, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // txtSteam
            // 
            txtSteam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSteam.Location = new Point(71, 27);
            txtSteam.Name = "txtSteam";
            txtSteam.Size = new Size(338, 23);
            txtSteam.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Steam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Android:";
            // 
            // txtAndroid
            // 
            txtAndroid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAndroid.Location = new Point(71, 56);
            txtAndroid.Name = "txtAndroid";
            txtAndroid.Size = new Size(338, 23);
            txtAndroid.TabIndex = 3;
            // 
            // btnChooseSteamSave
            // 
            btnChooseSteamSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseSteamSave.Location = new Point(415, 27);
            btnChooseSteamSave.Name = "btnChooseSteamSave";
            btnChooseSteamSave.Size = new Size(25, 23);
            btnChooseSteamSave.TabIndex = 4;
            btnChooseSteamSave.Text = "...";
            btnChooseSteamSave.UseVisualStyleBackColor = true;
            btnChooseSteamSave.Click += BtnChooseSteamSave_Click;
            // 
            // btnChooseAndroidSave
            // 
            btnChooseAndroidSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseAndroidSave.Location = new Point(415, 56);
            btnChooseAndroidSave.Name = "btnChooseAndroidSave";
            btnChooseAndroidSave.Size = new Size(25, 23);
            btnChooseAndroidSave.TabIndex = 5;
            btnChooseAndroidSave.Text = "...";
            btnChooseAndroidSave.UseVisualStyleBackColor = true;
            btnChooseAndroidSave.Click += BtnChooseAndroidSave_Click;
            // 
            // btnSyncSteamAndroid
            // 
            btnSyncSteamAndroid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSyncSteamAndroid.Location = new Point(12, 96);
            btnSyncSteamAndroid.Name = "btnSyncSteamAndroid";
            btnSyncSteamAndroid.Size = new Size(428, 30);
            btnSyncSteamAndroid.TabIndex = 6;
            btnSyncSteamAndroid.Text = "Sync Steam To Android";
            btnSyncSteamAndroid.UseVisualStyleBackColor = true;
            btnSyncSteamAndroid.Click += BtnSyncSteamAndroid_Click;
            // 
            // btnSyncAndroidSteam
            // 
            btnSyncAndroidSteam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSyncAndroidSteam.Location = new Point(12, 132);
            btnSyncAndroidSteam.Name = "btnSyncAndroidSteam";
            btnSyncAndroidSteam.Size = new Size(428, 30);
            btnSyncAndroidSteam.TabIndex = 7;
            btnSyncAndroidSteam.Text = "Sync Android To Steam";
            btnSyncAndroidSteam.UseVisualStyleBackColor = true;
            btnSyncAndroidSteam.Click += BtnSyncAndroidSteam_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 173);
            Controls.Add(btnSyncAndroidSteam);
            Controls.Add(btnSyncSteamAndroid);
            Controls.Add(btnChooseAndroidSave);
            Controls.Add(btnChooseSteamSave);
            Controls.Add(txtAndroid);
            Controls.Add(label2);
            Controls.Add(txtSteam);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox txtSteam;
        private Label label1;
        private Label label2;
        private TextBox txtAndroid;
        private Button btnChooseSteamSave;
        private Button btnChooseAndroidSave;
        private Button btnSyncSteamAndroid;
        private Button btnSyncAndroidSteam;
    }
}