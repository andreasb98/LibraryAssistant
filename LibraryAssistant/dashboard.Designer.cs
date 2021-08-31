
namespace LibraryAssistant
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(177)))), ((int)(((byte)(135)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 157);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(177)))), ((int)(((byte)(135)))));
            this.txtUsername.Location = new System.Drawing.Point(26, 88);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(118, 19);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Library Assistant";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(192, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Books";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(914, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.pnlSide.Controls.Add(this.btnLogout);
            this.pnlSide.Controls.Add(this.pnlNav);
            this.pnlSide.Controls.Add(this.btnSettings);
            this.pnlSide.Controls.Add(this.btnMembers);
            this.pnlSide.Controls.Add(this.btnBooks);
            this.pnlSide.Controls.Add(this.panel1);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(186, 577);
            this.pnlSide.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::LibraryAssistant.Properties.Resources.outline_logout_white_24dp;
            this.btnLogout.Location = new System.Drawing.Point(0, 527);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(145)))), ((int)(((byte)(162)))));
            this.btnSettings.Image = global::LibraryAssistant.Properties.Resources.outline_settings_white_24dp;
            this.btnSettings.Location = new System.Drawing.Point(0, 240);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 50);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(145)))), ((int)(((byte)(162)))));
            this.btnMembers.Image = global::LibraryAssistant.Properties.Resources.outline_groups_white_24dp;
            this.btnMembers.Location = new System.Drawing.Point(0, 190);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(186, 50);
            this.btnMembers.TabIndex = 6;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            this.btnMembers.Leave += new System.EventHandler(this.btnMembers_Leave);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(145)))), ((int)(((byte)(162)))));
            this.btnBooks.Image = global::LibraryAssistant.Properties.Resources.outline_menu_book_white_24dp;
            this.btnBooks.Location = new System.Drawing.Point(0, 140);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(186, 50);
            this.btnBooks.TabIndex = 6;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            this.btnBooks.Leave += new System.EventHandler(this.btnBooks_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 140);
            this.panel1.TabIndex = 6;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(186, 52);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(765, 525);
            this.pnlFormLoader.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(145)))), ((int)(((byte)(162)))));
            this.lblUser.Location = new System.Drawing.Point(52, 107);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblUser;
    }
}