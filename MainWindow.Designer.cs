using System.Configuration;

namespace Grand_Theft_Auto_V_Platform_Switcher
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblTextGameVer = new System.Windows.Forms.Label();
            this.lblGameVer = new System.Windows.Forms.Label();
            this.BtnLaunch = new System.Windows.Forms.Button();
            this.btnFixPlayOnSteam = new System.Windows.Forms.Button();
            this.btnSteamInstalled = new System.Windows.Forms.Button();
            this.Extra = new System.Windows.Forms.Label();
            this.btnEpic = new System.Windows.Forms.Button();
            this.BtnSteam = new System.Windows.Forms.Button();
            this.BtnRGL = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troubleshootingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFixPlayOnEpic = new System.Windows.Forms.Button();
            this.btnInstallEpic = new System.Windows.Forms.Button();
            this.lblRunAsAdmin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTextGameVer
            // 
            this.lblTextGameVer.AutoSize = true;
            this.lblTextGameVer.Location = new System.Drawing.Point(12, 196);
            this.lblTextGameVer.Name = "lblTextGameVer";
            this.lblTextGameVer.Size = new System.Drawing.Size(123, 65);
            this.lblTextGameVer.TabIndex = 4;
            this.lblTextGameVer.Text = "Game version:\r\nRGL files version:\r\nSteam files version:\r\nEpic games files version" + ":\r\nCurrent platform:";
            this.lblTextGameVer.Click += new System.EventHandler(this.LblTextGameVer_Click);
            // 
            // lblGameVer
            // 
            this.lblGameVer.AutoSize = true;
            this.lblGameVer.Location = new System.Drawing.Point(141, 196);
            this.lblGameVer.Name = "lblGameVer";
            this.lblGameVer.Size = new System.Drawing.Size(94, 65);
            this.lblGameVer.TabIndex = 5;
            this.lblGameVer.Text = "varGameVer\r\nvarRGLVer\r\nvarSteamVer\r\nvarEpicVer\r\nvarCurrentPlatform\r\n";
            this.lblGameVer.Click += new System.EventHandler(this.LblGameVer_Click);
            // 
            // BtnLaunch
            // 
            this.BtnLaunch.Location = new System.Drawing.Point(15, 264);
            this.BtnLaunch.Name = "BtnLaunch";
            this.BtnLaunch.Size = new System.Drawing.Size(201, 23);
            this.BtnLaunch.TabIndex = 0;
            this.BtnLaunch.Text = "&Launch Game";
            this.BtnLaunch.UseVisualStyleBackColor = true;
            this.BtnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            // 
            // btnFixPlayOnSteam
            // 
            this.btnFixPlayOnSteam.Location = new System.Drawing.Point(222, 179);
            this.btnFixPlayOnSteam.Name = "btnFixPlayOnSteam";
            this.btnFixPlayOnSteam.Size = new System.Drawing.Size(171, 23);
            this.btnFixPlayOnSteam.TabIndex = 5;
            this.btnFixPlayOnSteam.Text = "Remove \"on Steam\" from RGL\r\n";
            this.btnFixPlayOnSteam.UseVisualStyleBackColor = true;
            this.btnFixPlayOnSteam.Click += new System.EventHandler(this.btnFixPlayOnSteam_Click);
            // 
            // btnSteamInstalled
            // 
            this.btnSteamInstalled.Location = new System.Drawing.Point(222, 237);
            this.btnSteamInstalled.Name = "btnSteamInstalled";
            this.btnSteamInstalled.Size = new System.Drawing.Size(171, 23);
            this.btnSteamInstalled.TabIndex = 7;
            this.btnSteamInstalled.Text = "Add \"on Steam\" to RGL";
            this.btnSteamInstalled.UseVisualStyleBackColor = true;
            this.btnSteamInstalled.Click += new System.EventHandler(this.btnSteamInstalled_Click);
            // 
            // Extra
            // 
            this.Extra.AutoSize = true;
            this.Extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Extra.Location = new System.Drawing.Point(218, 152);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(183, 24);
            this.Extra.TabIndex = 8;
            this.Extra.Text = "Additional options:";
            // 
            // btnEpic
            // 
            this.btnEpic.BackgroundImage = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.EGL;
            this.btnEpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEpic.Location = new System.Drawing.Point(270, 27);
            this.btnEpic.Name = "btnEpic";
            this.btnEpic.Size = new System.Drawing.Size(123, 123);
            this.btnEpic.TabIndex = 4;
            this.btnEpic.UseVisualStyleBackColor = true;
            this.btnEpic.Click += new System.EventHandler(this.btnEpic_Click);
            // 
            // BtnSteam
            // 
            this.BtnSteam.BackgroundImage = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.Steam;
            this.BtnSteam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSteam.Location = new System.Drawing.Point(141, 27);
            this.BtnSteam.Name = "BtnSteam";
            this.BtnSteam.Size = new System.Drawing.Size(123, 123);
            this.BtnSteam.TabIndex = 3;
            this.BtnSteam.UseVisualStyleBackColor = true;
            this.BtnSteam.Click += new System.EventHandler(this.BtnSteam_Click);
            // 
            // BtnRGL
            // 
            this.BtnRGL.BackgroundImage = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.RGL;
            this.BtnRGL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRGL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRGL.ForeColor = System.Drawing.Color.White;
            this.BtnRGL.Location = new System.Drawing.Point(12, 27);
            this.BtnRGL.Name = "BtnRGL";
            this.BtnRGL.Size = new System.Drawing.Size(123, 123);
            this.BtnRGL.TabIndex = 2;
            this.BtnRGL.UseVisualStyleBackColor = true;
            this.BtnRGL.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.checkForUpdatesToolStripMenuItem, this.toolStripMenuItem2, this.exitToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Enabled = false;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "&Total rework project has started, stay tuned...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(305, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.aboutToolStripMenuItem, this.troubleshootingToolStripMenuItem });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // troubleshootingToolStripMenuItem
            // 
            this.troubleshootingToolStripMenuItem.Name = "troubleshootingToolStripMenuItem";
            this.troubleshootingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.troubleshootingToolStripMenuItem.Text = "&How to install and use";
            this.troubleshootingToolStripMenuItem.Click += new System.EventHandler(this.troubleshootingToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.helpToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnFixPlayOnEpic
            // 
            this.btnFixPlayOnEpic.Location = new System.Drawing.Point(222, 208);
            this.btnFixPlayOnEpic.Name = "btnFixPlayOnEpic";
            this.btnFixPlayOnEpic.Size = new System.Drawing.Size(171, 23);
            this.btnFixPlayOnEpic.TabIndex = 6;
            this.btnFixPlayOnEpic.Text = "Remove \"on Epic\" from RGL";
            this.btnFixPlayOnEpic.UseVisualStyleBackColor = true;
            this.btnFixPlayOnEpic.Click += new System.EventHandler(this.btnFixPlayOnEpic_Click);
            // 
            // btnInstallEpic
            // 
            this.btnInstallEpic.Location = new System.Drawing.Point(222, 264);
            this.btnInstallEpic.Name = "btnInstallEpic";
            this.btnInstallEpic.Size = new System.Drawing.Size(171, 23);
            this.btnInstallEpic.TabIndex = 8;
            this.btnInstallEpic.Text = "Add \"on Epic\" to RGL";
            this.btnInstallEpic.UseVisualStyleBackColor = true;
            this.btnInstallEpic.Click += new System.EventHandler(this.btnInstallEpic_Click);
            // 
            // lblRunAsAdmin
            // 
            this.lblRunAsAdmin.AutoSize = true;
            this.lblRunAsAdmin.Location = new System.Drawing.Point(9, 160);
            this.lblRunAsAdmin.Name = "lblRunAsAdmin";
            this.lblRunAsAdmin.Size = new System.Drawing.Size(192, 13);
            this.lblRunAsAdmin.TabIndex = 9;
            this.lblRunAsAdmin.Text = "Run as admin to enable locked buttons";
            this.lblRunAsAdmin.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 304);
            this.Controls.Add(this.lblRunAsAdmin);
            this.Controls.Add(this.btnInstallEpic);
            this.Controls.Add(this.btnFixPlayOnEpic);
            this.Controls.Add(this.btnEpic);
            this.Controls.Add(this.Extra);
            this.Controls.Add(this.btnSteamInstalled);
            this.Controls.Add(this.btnFixPlayOnSteam);
            this.Controls.Add(this.BtnLaunch);
            this.Controls.Add(this.lblGameVer);
            this.Controls.Add(this.lblTextGameVer);
            this.Controls.Add(this.BtnSteam);
            this.Controls.Add(this.BtnRGL);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Grand Theft Auto V Platform Switcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BtnRGL;
        private System.Windows.Forms.Button BtnSteam;
        private System.Windows.Forms.Label lblTextGameVer;
        private System.Windows.Forms.Label lblGameVer;
        private System.Windows.Forms.Button BtnLaunch;
        private System.Windows.Forms.Button btnFixPlayOnSteam;
        private System.Windows.Forms.Button btnSteamInstalled;
        private System.Windows.Forms.Label Extra;
        private System.Windows.Forms.Button btnEpic;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troubleshootingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnFixPlayOnEpic;
        private System.Windows.Forms.Button btnInstallEpic;
        private System.Windows.Forms.Label lblRunAsAdmin;

        public object CurrentPlatform { get; private set; }
    }
}

