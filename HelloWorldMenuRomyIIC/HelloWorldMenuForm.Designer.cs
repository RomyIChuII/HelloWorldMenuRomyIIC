﻿namespace HelloWorldMenuRomyIIC
{
    partial class frmHelloWorldMenu
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
            this.mnuFileMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.mnuFileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFileMenu
            // 
            this.mnuFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFileMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuFileMenu.Name = "mnuFileMenu";
            this.mnuFileMenu.Size = new System.Drawing.Size(446, 24);
            this.mnuFileMenu.TabIndex = 0;
            this.mnuFileMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.BackColor = System.Drawing.Color.Orange;
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblGreeting.Font = new System.Drawing.Font("Prestige Elite Std", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(62, 202);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(311, 40);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "HELLO, ROMYIIC";
            // 
            // frmHelloWorldMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(446, 239);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.mnuFileMenu);
            this.MainMenuStrip = this.mnuFileMenu;
            this.Name = "frmHelloWorldMenu";
            this.Text = "Hello, World! With Menu By RomyIIC";
            this.mnuFileMenu.ResumeLayout(false);
            this.mnuFileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblGreeting;
    }
}

