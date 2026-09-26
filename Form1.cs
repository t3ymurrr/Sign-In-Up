using System;
using System.Windows.Forms;

namespace SignInUp
{
    public partial class Form1 : Form
    {
        string username = "";
        string password = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtRegUsername.Text == "" || txtRegPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            username = txtRegUsername.Text;
            password = txtRegPassword.Text;

            MessageBox.Show("Registration successful!");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Sign in successful!");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void chkRegShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtRegPassword.UseSystemPasswordChar = !chkRegShowPassword.Checked;
        }
    }
}