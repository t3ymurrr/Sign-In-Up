namespace SignInUp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxSignIn;
        private System.Windows.Forms.GroupBox groupBoxRegistration;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.Label lblRegPassword;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;

        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.CheckBox chkRegShowPassword;

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.groupBoxRegistration = new System.Windows.Forms.GroupBox();

            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();

            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();

            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.chkRegShowPassword = new System.Windows.Forms.CheckBox();

            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();

            this.groupBoxSignIn.SuspendLayout();
            this.groupBoxRegistration.SuspendLayout();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(760, 330);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.Name = "Form1";

            this.groupBoxSignIn.Location = new System.Drawing.Point(25, 35);
            this.groupBoxSignIn.Size = new System.Drawing.Size(320, 255);
            this.groupBoxSignIn.Text = "Sign in";
            this.groupBoxSignIn.ForeColor = System.Drawing.Color.White;

            this.lblUsername.Location = new System.Drawing.Point(25, 30);
            this.lblUsername.Size = new System.Drawing.Size(100, 20);
            this.lblUsername.Text = "Username";
            this.lblUsername.ForeColor = System.Drawing.Color.White;

            this.txtUsername.Location = new System.Drawing.Point(25, 55);
            this.txtUsername.Size = new System.Drawing.Size(270, 27);

            this.lblPassword.Location = new System.Drawing.Point(25, 95);
            this.lblPassword.Size = new System.Drawing.Size(100, 20);
            this.lblPassword.Text = "Password";
            this.lblPassword.ForeColor = System.Drawing.Color.White;

            this.txtPassword.Location = new System.Drawing.Point(25, 120);
            this.txtPassword.Size = new System.Drawing.Size(270, 27);
            this.txtPassword.UseSystemPasswordChar = true;

            this.chkShowPassword.Location = new System.Drawing.Point(25, 155);
            this.chkShowPassword.Size = new System.Drawing.Size(160, 25);
            this.chkShowPassword.Text = "Show me password";
            this.chkShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            this.btnSignIn.Location = new System.Drawing.Point(55, 195);
            this.btnSignIn.Size = new System.Drawing.Size(210, 40);
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.BackColor = System.Drawing.Color.Green;
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);

            this.groupBoxSignIn.Controls.Add(this.lblUsername);
            this.groupBoxSignIn.Controls.Add(this.txtUsername);
            this.groupBoxSignIn.Controls.Add(this.lblPassword);
            this.groupBoxSignIn.Controls.Add(this.txtPassword);
            this.groupBoxSignIn.Controls.Add(this.chkShowPassword);
            this.groupBoxSignIn.Controls.Add(this.btnSignIn);

            this.groupBoxRegistration.Location = new System.Drawing.Point(400, 35);
            this.groupBoxRegistration.Size = new System.Drawing.Size(320, 255);
            this.groupBoxRegistration.Text = "Registration";
            this.groupBoxRegistration.ForeColor = System.Drawing.Color.White;

            this.lblRegUsername.Location = new System.Drawing.Point(25, 30);
            this.lblRegUsername.Size = new System.Drawing.Size(100, 20);
            this.lblRegUsername.Text = "Username";
            this.lblRegUsername.ForeColor = System.Drawing.Color.White;

            this.txtRegUsername.Location = new System.Drawing.Point(25, 55);
            this.txtRegUsername.Size = new System.Drawing.Size(270, 27);

            this.lblRegPassword.Location = new System.Drawing.Point(25, 95);
            this.lblRegPassword.Size = new System.Drawing.Size(100, 20);
            this.lblRegPassword.Text = "Password";
            this.lblRegPassword.ForeColor = System.Drawing.Color.White;

            this.txtRegPassword.Location = new System.Drawing.Point(25, 120);
            this.txtRegPassword.Size = new System.Drawing.Size(270, 27);
            this.txtRegPassword.UseSystemPasswordChar = true;

            this.chkRegShowPassword.Location = new System.Drawing.Point(25, 155);
            this.chkRegShowPassword.Size = new System.Drawing.Size(160, 25);
            this.chkRegShowPassword.Text = "Show me password";
            this.chkRegShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkRegShowPassword.CheckedChanged += new System.EventHandler(this.chkRegShowPassword_CheckedChanged);

            this.btnSignUp.Location = new System.Drawing.Point(55, 195);
            this.btnSignUp.Size = new System.Drawing.Size(210, 40);
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.BackColor = System.Drawing.Color.Green;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);

            this.groupBoxRegistration.Controls.Add(this.lblRegUsername);
            this.groupBoxRegistration.Controls.Add(this.txtRegUsername);
            this.groupBoxRegistration.Controls.Add(this.lblRegPassword);
            this.groupBoxRegistration.Controls.Add(this.txtRegPassword);
            this.groupBoxRegistration.Controls.Add(this.chkRegShowPassword);
            this.groupBoxRegistration.Controls.Add(this.btnSignUp);

            this.Controls.Add(this.groupBoxSignIn);
            this.Controls.Add(this.groupBoxRegistration);

            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxRegistration.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}