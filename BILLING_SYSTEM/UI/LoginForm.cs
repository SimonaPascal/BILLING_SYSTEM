using BILLING_SYSTEM.DataAccessObjects;
using BILLING_SYSTEM.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SYSTEM.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        LoginBLL user = new LoginBLL();
        LoginManager userDA = new LoginManager();
        public static string loggedUsername;

        private void logInButton_Click(object sender, EventArgs e)
        {
            
            user.username = usernamTxtBox.Text.Trim();
            user.password = passwordTxtBox.Text.Trim();

            bool success = userDA.loginCheck(user);

            if(success = true)
            {
                loggedUsername = user.username;
                UserDashboard frm = new UserDashboard();
                frm.Show();
                this.Hide();
         
            }
            else
            {
                MessageBox.Show("Login failes. Please try again!");
            }

            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
            this.Hide();
        }
    }
}
