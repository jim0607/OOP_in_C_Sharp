using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activity6_1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // declare and instantiate a variable of type employee called oEmployee
                Employee oEmployee = new Employee();
                // call the Login method of the oEmployee object, passing in the values of the login 
                // name and the password from the text boxes on the form. Capture the return value in a
                // Boolean variable called bResult
                Boolean bResult = oEmployee.Login(txtName.Text, txtPassword.Text);
                if (bResult == true) {
                    MessageBox.Show("Your security level is " + oEmployee.SecurityLevel);
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
