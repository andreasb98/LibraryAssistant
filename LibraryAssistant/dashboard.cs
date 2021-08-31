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

namespace LibraryAssistant
{
    public partial class dashboard : Form
    {
        LibraryService LibraryService = new LibraryService();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWithEllipse,
            int nHeightEllipse);

        public dashboard()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnBooks.Height;
            pnlNav.Top = btnBooks.Top;
            pnlNav.Left = btnBooks.Left;


            lblTitle.Text = "Books";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_ = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_);
            FrmDashboard_.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //lblUser.Text = brukernavn
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
            Console.WriteLine("Program exited from button");
            System.Diagnostics.Debug.WriteLine("Program exited from button");
            Application.Exit();
        }

       

        


        private  async void btnBooks_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBooks.Height;
            pnlNav.Top = btnBooks.Top;
            pnlNav.Left = btnBooks.Left;
            btnBooks.BackColor = Color.FromArgb(106, 177, 135);


            lblTitle.Text = "Books";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_ = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_);
            FrmDashboard_.Show();

            var temp = await LibraryService.GetBooks();

            foreach (var item in temp)
            {
                System.Diagnostics.Debug.WriteLine($"{item.Id}, {item.Title}");
            }

            //await LibraryService.GetMembers();


        }

        private async void btnMembers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMembers.Height;
            pnlNav.Top = btnMembers.Top;
            pnlNav.Left = btnMembers.Left;
            btnMembers.BackColor = Color.FromArgb(106, 177, 135);

            lblTitle.Text = "Members";
            this.pnlFormLoader.Controls.Clear();
            frmMembers FrmMemberrs_ = new frmMembers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmMemberrs_.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmMemberrs_);
            FrmMemberrs_.Show();

            var temp2 = await LibraryService.GetBook(2);
            System.Diagnostics.Debug.WriteLine($"{temp2.Id}, {temp2.Title}");
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(106, 177, 135);

            lblTitle.Text = "Settings";
            this.pnlFormLoader.Controls.Clear();
            frmSettings FrmSettings_ = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSettings_.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSettings_);
            FrmSettings_.Show();

          

            await LibraryService.DeleteBook(1);
        }

       

        private void btnlogout_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
