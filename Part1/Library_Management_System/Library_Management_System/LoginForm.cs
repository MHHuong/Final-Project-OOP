using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            registerPanel.Visible = false;

            passwordText.UseSystemPasswordChar = true;
            passwordText.UseSystemPasswordChar = true;

            confirmPasswordRegisterText.UseSystemPasswordChar = true;
            passwordRegisterText.UseSystemPasswordChar = true;
        }

        private void returnLoginForm_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = false;
            panelLogin.Visible = true;
        }

        private void createAccountLb_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
            panelLogin.Visible = false;
        }

        private void showPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordRegister.Checked)
            {
                confirmPasswordRegisterText.UseSystemPasswordChar = false;
                passwordRegisterText.UseSystemPasswordChar = false;
            }
            else
            {
                confirmPasswordRegisterText.UseSystemPasswordChar = true;
                passwordRegisterText.UseSystemPasswordChar = true;
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordText.UseSystemPasswordChar = false;
                passwordText.UseSystemPasswordChar = false;
            }
            else
            {
                passwordText.UseSystemPasswordChar = true;
                passwordText.UseSystemPasswordChar = true;
            }
        }
    }
}
