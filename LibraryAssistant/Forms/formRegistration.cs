using LibraryAssistant.Model;
using System;
using System.Windows.Forms;

namespace LibraryAssistant
{
    public partial class formRegister : Form
    {
        LibraryService libraryservice = new LibraryService();
        public formRegister()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            

            if (txtName.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                Member member = new Member();
                member.Email = txtEmail.Text;
                member.Mobile = txtPhone.Text;
                member.Name = txtName.Text;
                member.password = txtPassword.Text;               
                try
                {                   
                    await libraryservice.RegisterAccount(member);
                    
                    
                    
                    var generateToken = await libraryservice.Authorize(member);
                    var tokenRequest = await libraryservice.RefreshTokenRequest(member);
                    var response = await libraryservice.Login(member);

                    if (response.IsSuccessStatusCode)
                    {
                        await libraryservice.PostMember(member);
                        clearFields();
                        MessageBox.Show("Account successfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dashboard dashB = new dashboard(generateToken, tokenRequest)
                        {
                            userName = member.Name,
                            userEmail = member.Email,
                            userPassword = member.password,
                            //accessToken = generateToken
                        };
                        dashB.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("An error has occured", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }
                    
                }
                catch (Exception eg)
                {
                    MessageBox.Show("There was an error: " + eg.ToString(), "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Passwords does not match, please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
                txtConfirmPassword.Focus();
            }
        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtConfirmPassword.PasswordChar = '●';
            }
        }
        private void clearFields()
        {
            txtPassword.Text = "";
            txtName.Text = "";
            txtConfirmPassword.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            txtName.Focus();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
