﻿namespace Chatime
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopMenuBar = new System.Windows.Forms.Panel();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WebsiteButton = new System.Windows.Forms.Button();
            this.InstagramButton = new System.Windows.Forms.Button();
            this.FacebookButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.TeaButton = new System.Windows.Forms.Button();
            this.home1 = new Chatime.ViewModels.Embed.Home();
            this.teas1 = new Chatime.ViewModels.Embed.Teas();
            this.TopMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuBar
            // 
            this.TopMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMenuBar.Controls.Add(this.MinimiseButton);
            this.TopMenuBar.Controls.Add(this.CloseButton);
            this.TopMenuBar.Controls.Add(this.pictureBox1);
            this.TopMenuBar.Location = new System.Drawing.Point(0, 0);
            this.TopMenuBar.Name = "TopMenuBar";
            this.TopMenuBar.Size = new System.Drawing.Size(978, 52);
            this.TopMenuBar.TabIndex = 0;
            this.TopMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenuBar_MouseDown);
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimiseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimiseButton.BackgroundImage")));
            this.MinimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseButton.Location = new System.Drawing.Point(814, 0);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(79, 52);
            this.MinimiseButton.TabIndex = 3;
            this.MinimiseButton.UseVisualStyleBackColor = true;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(899, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(79, 52);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.WebsiteButton);
            this.SideBar.Controls.Add(this.InstagramButton);
            this.SideBar.Controls.Add(this.FacebookButton);
            this.SideBar.Controls.Add(this.InfoButton);
            this.SideBar.Controls.Add(this.HomeButton);
            this.SideBar.Controls.Add(this.TeaButton);
            this.SideBar.Location = new System.Drawing.Point(0, 50);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(75, 462);
            this.SideBar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(73, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 354);
            this.panel1.TabIndex = 6;
            // 
            // WebsiteButton
            // 
            this.WebsiteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WebsiteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WebsiteButton.BackgroundImage")));
            this.WebsiteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WebsiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebsiteButton.Location = new System.Drawing.Point(0, 148);
            this.WebsiteButton.Name = "WebsiteButton";
            this.WebsiteButton.Size = new System.Drawing.Size(75, 52);
            this.WebsiteButton.TabIndex = 9;
            this.WebsiteButton.UseVisualStyleBackColor = true;
            // 
            // InstagramButton
            // 
            this.InstagramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InstagramButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InstagramButton.BackgroundImage")));
            this.InstagramButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InstagramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstagramButton.Location = new System.Drawing.Point(0, 404);
            this.InstagramButton.Name = "InstagramButton";
            this.InstagramButton.Size = new System.Drawing.Size(75, 52);
            this.InstagramButton.TabIndex = 8;
            this.InstagramButton.UseVisualStyleBackColor = true;
            // 
            // FacebookButton
            // 
            this.FacebookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FacebookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FacebookButton.BackgroundImage")));
            this.FacebookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FacebookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacebookButton.Location = new System.Drawing.Point(0, 353);
            this.FacebookButton.Name = "FacebookButton";
            this.FacebookButton.Size = new System.Drawing.Size(75, 52);
            this.FacebookButton.TabIndex = 7;
            this.FacebookButton.UseVisualStyleBackColor = true;
            // 
            // InfoButton
            // 
            this.InfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoButton.BackgroundImage")));
            this.InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Location = new System.Drawing.Point(0, 96);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(75, 52);
            this.InfoButton.TabIndex = 6;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 52);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // TeaButton
            // 
            this.TeaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TeaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TeaButton.BackgroundImage")));
            this.TeaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TeaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeaButton.Location = new System.Drawing.Point(0, 49);
            this.TeaButton.Name = "TeaButton";
            this.TeaButton.Size = new System.Drawing.Size(75, 52);
            this.TeaButton.TabIndex = 4;
            this.TeaButton.UseVisualStyleBackColor = true;
            this.TeaButton.Click += new System.EventHandler(this.TeaButton_Click);
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(76, 50);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(902, 462);
            this.home1.TabIndex = 7;
            // 
            // teas1
            // 
            this.teas1.BackColor = System.Drawing.Color.White;
            this.teas1.Location = new System.Drawing.Point(73, 50);
            this.teas1.Name = "teas1";
            this.teas1.Size = new System.Drawing.Size(905, 462);
            this.teas1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 511);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.teas1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TopMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenuBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimiseButton;
        private System.Windows.Forms.Button TeaButton;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button FacebookButton;
        private System.Windows.Forms.Button InstagramButton;
        private System.Windows.Forms.Button WebsiteButton;
        private System.Windows.Forms.Panel panel1;
        private ViewModels.Embed.Teas teas1;
        private ViewModels.Embed.Home home1;
    }
}

