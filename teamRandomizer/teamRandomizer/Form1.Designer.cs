namespace teamRandomizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCurrentTeamConfiguration = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblNewTeamConfiguration = new System.Windows.Forms.Label();
            this.lblNumberOfGroups = new System.Windows.Forms.Label();
            this.txtNumberOfGroups = new System.Windows.Forms.TextBox();
            this.btnCreateGroups = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentTeamConfiguration
            // 
            this.lblCurrentTeamConfiguration.AutoSize = true;
            this.lblCurrentTeamConfiguration.Font = new System.Drawing.Font("Georgia", 12.75F);
            this.lblCurrentTeamConfiguration.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentTeamConfiguration.Location = new System.Drawing.Point(11, 75);
            this.lblCurrentTeamConfiguration.Name = "lblCurrentTeamConfiguration";
            this.lblCurrentTeamConfiguration.Size = new System.Drawing.Size(225, 20);
            this.lblCurrentTeamConfiguration.TabIndex = 0;
            this.lblCurrentTeamConfiguration.Text = "Current Team Configuration";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(25)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(448, 35);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(203, 27);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate New Configuration";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblNewTeamConfiguration
            // 
            this.lblNewTeamConfiguration.AutoSize = true;
            this.lblNewTeamConfiguration.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTeamConfiguration.ForeColor = System.Drawing.Color.Black;
            this.lblNewTeamConfiguration.Location = new System.Drawing.Point(372, 75);
            this.lblNewTeamConfiguration.Name = "lblNewTeamConfiguration";
            this.lblNewTeamConfiguration.Size = new System.Drawing.Size(200, 20);
            this.lblNewTeamConfiguration.TabIndex = 14;
            this.lblNewTeamConfiguration.Text = "New Team Configuration";
            // 
            // lblNumberOfGroups
            // 
            this.lblNumberOfGroups.AutoSize = true;
            this.lblNumberOfGroups.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGroups.Location = new System.Drawing.Point(12, 40);
            this.lblNumberOfGroups.Name = "lblNumberOfGroups";
            this.lblNumberOfGroups.Size = new System.Drawing.Size(117, 16);
            this.lblNumberOfGroups.TabIndex = 15;
            this.lblNumberOfGroups.Text = "Number of Groups:";
            // 
            // txtNumberOfGroups
            // 
            this.txtNumberOfGroups.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfGroups.Location = new System.Drawing.Point(134, 37);
            this.txtNumberOfGroups.MaxLength = 2;
            this.txtNumberOfGroups.Name = "txtNumberOfGroups";
            this.txtNumberOfGroups.Size = new System.Drawing.Size(66, 23);
            this.txtNumberOfGroups.TabIndex = 1;
            this.txtNumberOfGroups.TextChanged += new System.EventHandler(this.txtNumberOfGroups_TextChanged);
            // 
            // btnCreateGroups
            // 
            this.btnCreateGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(25)))));
            this.btnCreateGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGroups.ForeColor = System.Drawing.Color.White;
            this.btnCreateGroups.Location = new System.Drawing.Point(215, 35);
            this.btnCreateGroups.Name = "btnCreateGroups";
            this.btnCreateGroups.Size = new System.Drawing.Size(112, 27);
            this.btnCreateGroups.TabIndex = 17;
            this.btnCreateGroups.Text = "Create Groups";
            this.btnCreateGroups.UseVisualStyleBackColor = false;
            this.btnCreateGroups.Click += new System.EventHandler(this.btnCreateGroups_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.ShortcutKeyDisplayString = "";
            this.mnuFile.Size = new System.Drawing.Size(40, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mniExit
            // 
            this.mniExit.BackColor = System.Drawing.Color.White;
            this.mniExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mniExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mniExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniExit.Name = "mniExit";
            this.mniExit.ShortcutKeyDisplayString = "";
            this.mniExit.Size = new System.Drawing.Size(96, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniExit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAbout});
            this.mnuHelp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.ShortcutKeyDisplayString = "";
            this.mnuHelp.Size = new System.Drawing.Size(43, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mniAbout
            // 
            this.mniAbout.BackColor = System.Drawing.Color.White;
            this.mniAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.ShortcutKeyDisplayString = "";
            this.mniAbout.Size = new System.Drawing.Size(108, 22);
            this.mniAbout.Text = "About";
            this.mniAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniAbout.Click += new System.EventHandler(this.mniAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 310);
            this.Controls.Add(this.btnCreateGroups);
            this.Controls.Add(this.txtNumberOfGroups);
            this.Controls.Add(this.lblNumberOfGroups);
            this.Controls.Add(this.lblNewTeamConfiguration);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblCurrentTeamConfiguration);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Team Location Randomizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTeamConfiguration;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblNewTeamConfiguration;
        private System.Windows.Forms.Label lblNumberOfGroups;
        private System.Windows.Forms.TextBox txtNumberOfGroups;
        private System.Windows.Forms.Button btnCreateGroups;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mniAbout;



    }
}

