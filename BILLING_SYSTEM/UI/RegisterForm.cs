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
    public partial class RegisterForm : Form
    {
        User user = new User();
        UserManager userManager = new UserManager();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            user.first_name = firstNameTxtBox.Text;
            user.last_name = lastNameTxtBox.Text;
            user.email = emailRegisterTextBox.Text;
            user.password = passwordRegisterTextBox.Text;
            user.username = usernameRegisterTextBox.Text;

            bool success = userManager.insert(user);

            if(success == true)
            {
                MessageBox.Show("User successfully created!");
                LoginForm frm = new LoginForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to add new user!");
            }
        }
    }
}
