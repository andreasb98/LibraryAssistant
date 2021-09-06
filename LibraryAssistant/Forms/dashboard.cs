using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using LibraryAssistant.Model;
using LibraryAssistant.Configuration;
using LibraryAssistant.Model.DTOs;

namespace LibraryAssistant
{
    public partial class dashboard : Form
    {
        LibraryService LibraryService = new LibraryService();
        public string accessToken = "";
        public AuthResult authTokens;
        
        string authToken = "";
        public string userEmail = "";
        public string userName = "";
        public string userPassword = "";
        Member member = new Member();

        public TokenRequest tokenRequest;


        //Runde kanter
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWithEllipse,
            int nHeightEllipse);

        public dashboard(AuthResult authTokens, TokenRequest _tokenRequest)
        {
            InitializeComponent();
            authToken = authTokens.Token;
            var tokenRequest = _tokenRequest;
           

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnBooks.Height;
            pnlNav.Top = btnBooks.Top;
            pnlNav.Left = btnBooks.Left;

            
            this.pnlFormLoader.Controls.Clear();

            tokenRequest.Token = authTokens.Token;
            tokenRequest.RefreshToken = authTokens.RefreshToken;
            frmDashboard FrmDashboard_ = new frmDashboard(authTokens, tokenRequest) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_);
            FrmDashboard_.Show();       
        }

        private void dashboard_Load(object sender, EventArgs e)
        {           
            member.Email = userEmail;
            lblUser.Text = member.Email;
            member.password = userPassword;
            member.Token = accessToken;         
        }


        private void btnBooks_Leave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.FromArgb(49, 58, 70);
        }

        private void btnMembers_Leave(object sender, EventArgs e)
        {
            btnMembers.BackColor = Color.FromArgb(49, 58, 70);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(49, 58, 70);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Console.WriteLine("Program exited from button");
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
            {
                //Not exiting
            }
        }

       

        


        private async void btnBooks_Click(object sender, EventArgs e)
        {
            lblPanelTitle.Text = "Books";
            pnlNav.Height = btnBooks.Height;
            pnlNav.Top = btnBooks.Top;
            pnlNav.Left = btnBooks.Left;
            btnBooks.BackColor = Color.FromArgb(106, 177, 135);

            
            this.pnlFormLoader.Controls.Clear();

            try
            {
                tokenRequest = await LibraryService.RefreshTokenRequest(member);
                frmDashboard FrmDashboard_ = new frmDashboard(authTokens, tokenRequest)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                FrmDashboard_.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(FrmDashboard_);
                FrmDashboard_.MaximizeBox = false;
                FrmDashboard_.MinimizeBox = false;
                FrmDashboard_.ShowInTaskbar = false;
                FrmDashboard_.Show();
            }
            catch (Exception ee)
            {
                tokenRequest = await LibraryService.RefreshTokenRequest(member);
                frmDashboard FrmDashboard_ = new frmDashboard(authTokens, tokenRequest)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                FrmDashboard_.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(FrmDashboard_);
                FrmDashboard_.Show();
            }
            
            




        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            lblPanelTitle.Text = "Members";
            pnlNav.Height = btnMembers.Height;
            pnlNav.Top = btnMembers.Top;
            pnlNav.Left = btnMembers.Left;
            btnMembers.BackColor = Color.FromArgb(106, 177, 135);

            
            this.pnlFormLoader.Controls.Clear();
            frmMembers FrmMemberrs_ = new frmMembers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmMemberrs_.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmMemberrs_);
            FrmMemberrs_.Show();                     
            
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblPanelTitle.Text = "Settings";
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(106, 177, 135);

            
            this.pnlFormLoader.Controls.Clear();
            frmSettings FrmSettings_ = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSettings_.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSettings_);
            FrmSettings_.Show();
        }

       

        private void btnlogout_Click(object sender, EventArgs e)
        {
            member.Name = "";
            member.password = "";
            member.Email = "";
            member.Id = 0;
            member.Mobile = "";
            member.Token = "";
            new formLogin().Show();
            this.Hide();
        }

      

      
        
            

        

    }
}
