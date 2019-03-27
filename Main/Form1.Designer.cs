namespace Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primaPaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraseEuropeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraseAmericaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraseDinAfricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.australiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Small", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primaPaginaToolStripMenuItem,
            this.oraseToolStripMenuItem,
            this.galerieToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 43);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primaPaginaToolStripMenuItem
            // 
            this.primaPaginaToolStripMenuItem.Name = "primaPaginaToolStripMenuItem";
            this.primaPaginaToolStripMenuItem.Size = new System.Drawing.Size(195, 39);
            this.primaPaginaToolStripMenuItem.Text = "Prima pagina";
            this.primaPaginaToolStripMenuItem.Click += new System.EventHandler(this.primaPaginaToolStripMenuItem_Click);
            // 
            // oraseToolStripMenuItem
            // 
            this.oraseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oraseEuropeneToolStripMenuItem,
            this.oraseAmericaneToolStripMenuItem,
            this.oraseDinAfricaToolStripMenuItem,
            this.asiaToolStripMenuItem,
            this.asiaToolStripMenuItem1,
            this.australiaToolStripMenuItem});
            this.oraseToolStripMenuItem.Name = "oraseToolStripMenuItem";
            this.oraseToolStripMenuItem.Size = new System.Drawing.Size(152, 39);
            this.oraseToolStripMenuItem.Text = "Destinatii";
            this.oraseToolStripMenuItem.Click += new System.EventHandler(this.oraseToolStripMenuItem_Click);
            // 
            // oraseEuropeneToolStripMenuItem
            // 
            this.oraseEuropeneToolStripMenuItem.Name = "oraseEuropeneToolStripMenuItem";
            this.oraseEuropeneToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.oraseEuropeneToolStripMenuItem.Text = "Europa";
            this.oraseEuropeneToolStripMenuItem.Click += new System.EventHandler(this.oraseEuropeneToolStripMenuItem_Click);
            // 
            // oraseAmericaneToolStripMenuItem
            // 
            this.oraseAmericaneToolStripMenuItem.Name = "oraseAmericaneToolStripMenuItem";
            this.oraseAmericaneToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.oraseAmericaneToolStripMenuItem.Text = "America de Nord";
            this.oraseAmericaneToolStripMenuItem.Click += new System.EventHandler(this.oraseAmericaneToolStripMenuItem_Click);
            // 
            // oraseDinAfricaToolStripMenuItem
            // 
            this.oraseDinAfricaToolStripMenuItem.Name = "oraseDinAfricaToolStripMenuItem";
            this.oraseDinAfricaToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.oraseDinAfricaToolStripMenuItem.Text = "America de Sud";
            this.oraseDinAfricaToolStripMenuItem.Click += new System.EventHandler(this.oraseDinAfricaToolStripMenuItem_Click);
            // 
            // asiaToolStripMenuItem
            // 
            this.asiaToolStripMenuItem.Name = "asiaToolStripMenuItem";
            this.asiaToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.asiaToolStripMenuItem.Text = "Africa";
            this.asiaToolStripMenuItem.Click += new System.EventHandler(this.asiaToolStripMenuItem_Click);
            // 
            // asiaToolStripMenuItem1
            // 
            this.asiaToolStripMenuItem1.Name = "asiaToolStripMenuItem1";
            this.asiaToolStripMenuItem1.Size = new System.Drawing.Size(304, 40);
            this.asiaToolStripMenuItem1.Text = "Asia";
            this.asiaToolStripMenuItem1.Click += new System.EventHandler(this.asiaToolStripMenuItem1_Click);
            // 
            // australiaToolStripMenuItem
            // 
            this.australiaToolStripMenuItem.Name = "australiaToolStripMenuItem";
            this.australiaToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.australiaToolStripMenuItem.Text = "Australia";
            this.australiaToolStripMenuItem.Click += new System.EventHandler(this.australiaToolStripMenuItem_Click);
            // 
            // galerieToolStripMenuItem
            // 
            this.galerieToolStripMenuItem.Name = "galerieToolStripMenuItem";
            this.galerieToolStripMenuItem.Size = new System.Drawing.Size(330, 39);
            this.galerieToolStripMenuItem.Text = "Orase ce trebuie vizitate";
            this.galerieToolStripMenuItem.Click += new System.EventHandler(this.galerieToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(262, 39);
            this.contactToolStripMenuItem.Text = "Dorinte de vizitare";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(91, 39);
            this.logInToolStripMenuItem.Text = "Lista";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main.Properties.Resources.background1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1148, 683);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1148, 683);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1148, 683);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 710);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1157, 757);
            this.MinimumSize = new System.Drawing.Size(1157, 757);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Traveller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primaPaginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galerieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem oraseEuropeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oraseAmericaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oraseDinAfricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem australiaToolStripMenuItem;
    }
}

