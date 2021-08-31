
namespace LibraryAssistant
{
    partial class frmDashboard
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
            this.lblbooks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbooks
            // 
            this.lblbooks.AutoSize = true;
            this.lblbooks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbooks.ForeColor = System.Drawing.Color.Black;
            this.lblbooks.Location = new System.Drawing.Point(326, 194);
            this.lblbooks.Name = "lblbooks";
            this.lblbooks.Size = new System.Drawing.Size(67, 13);
            this.lblbooks.TabIndex = 0;
            this.lblbooks.Text = "Books Form";
            this.lblbooks.Click += new System.EventHandler(this.lblbooks_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.lblbooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbooks;
    }
}