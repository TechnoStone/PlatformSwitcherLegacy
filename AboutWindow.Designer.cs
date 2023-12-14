namespace Grand_Theft_Auto_V_Platform_Switcher
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.LblClickQIWI = new System.Windows.Forms.LinkLabel();
            this.LblProductVersion = new System.Windows.Forms.Label();
            this.LinkLblTS = new System.Windows.Forms.LinkLabel();
            this.LinkLblTG = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(359, 244);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "&OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(12, 167);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(417, 60);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Utility for easy switching between Rockstar Games\r\nLauncher, Steam and Epic Games" +
    " Launcher with just only\r\none installation";
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Location = new System.Drawing.Point(13, 227);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(116, 13);
            this.lblMadeBy.TabIndex = 2;
            this.lblMadeBy.Text = "Made by TechnoStone";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(202)));
            this.lblProductName.Location = new System.Drawing.Point(0, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(445, 29);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Grand Theft Auto V Platform Switcher";
            // 
            // LblClickQIWI
            // 
            this.LblClickQIWI.AutoSize = true;
            this.LblClickQIWI.Location = new System.Drawing.Point(93, 249);
            this.LblClickQIWI.Name = "LblClickQIWI";
            this.LblClickQIWI.Size = new System.Drawing.Size(42, 13);
            this.LblClickQIWI.TabIndex = 5;
            this.LblClickQIWI.TabStop = true;
            this.LblClickQIWI.Text = "Donate";
            this.LblClickQIWI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LblProductVersion
            // 
            this.LblProductVersion.AutoSize = true;
            this.LblProductVersion.Location = new System.Drawing.Point(13, 249);
            this.LblProductVersion.Name = "LblProductVersion";
            this.LblProductVersion.Size = new System.Drawing.Size(74, 13);
            this.LblProductVersion.TabIndex = 6;
            this.LblProductVersion.Text = "LblProductVer";
            this.LblProductVersion.Click += new System.EventHandler(this.LblProductVersion_Click);
            // 
            // LinkLblTS
            // 
            this.LinkLblTS.AutoSize = true;
            this.LinkLblTS.Location = new System.Drawing.Point(135, 227);
            this.LinkLblTS.Name = "LinkLblTS";
            this.LinkLblTS.Size = new System.Drawing.Size(60, 13);
            this.LinkLblTS.TabIndex = 9;
            this.LinkLblTS.TabStop = true;
            this.LinkLblTS.Text = "My website";
            this.LinkLblTS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblTS_LinkClicked);
            // 
            // LinkLblTG
            // 
            this.LinkLblTG.AutoSize = true;
            this.LinkLblTG.Location = new System.Drawing.Point(201, 227);
            this.LinkLblTG.Name = "LinkLblTG";
            this.LinkLblTG.Size = new System.Drawing.Size(51, 13);
            this.LinkLblTG.TabIndex = 10;
            this.LinkLblTG.TabStop = true;
            this.LinkLblTG.Text = "Telegram";
            this.LinkLblTG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblTG_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Grand_Theft_Auto_V_Platform_Switcher.Properties.Resources.Switcher;
            this.pictureBox1.Location = new System.Drawing.Point(5, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(446, 271);
            this.Controls.Add(this.LinkLblTG);
            this.Controls.Add(this.LinkLblTS);
            this.Controls.Add(this.LblProductVersion);
            this.Controls.Add(this.LblClickQIWI);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.LinkLabel LblClickQIWI;
        private System.Windows.Forms.Label LblProductVersion;
        private System.Windows.Forms.LinkLabel LinkLblTS;
        private System.Windows.Forms.LinkLabel LinkLblTG;
    }
}