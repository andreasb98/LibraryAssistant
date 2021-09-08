using LibraryAssistant.Model;
using LibraryAssistant.Model.DTOs;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAssistant
{
    public partial class formLogin : Form
    {

        LibraryService libraryService = new LibraryService();
        public formLogin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            new formRegister().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            if (txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                member.Email = txtEmail.Text;
                member.password = txtPassword.Text;
                

                try
                {             
                    var generateToken = await libraryService.Authorize(member);
                    var tokenRequest = await libraryService.RefreshTokenRequest(member);


                    var response = await libraryService.Login(member);
                    if (response.IsSuccessStatusCode)
                    {
                        dashboard dashB = new dashboard(generateToken, tokenRequest)
                        {
                            userName = member.Name,
                            userEmail = member.Email,
                            userPassword = member.password,
                        };
                        dashB.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                    }                    

                }
                catch (Exception er)
                {
                    MessageBox.Show("There was an error: " + er.ToString(), "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtEmail.Focus();
        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
