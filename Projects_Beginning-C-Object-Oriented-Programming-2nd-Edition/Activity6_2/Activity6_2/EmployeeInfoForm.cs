using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activity6_2
{
    public partial class EmployeeInfoForm : Form
    {
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmpID.Text = "";
            txtEmpID.Enabled = true;
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtSSN.Text = "";
            txtDepartment.Text = "";
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            // in the click event method body, declare and instantiate a variable of type employee called oEmployee.
            Employee oEmployee = new Employee();

            //  update the employeeiD text box with the employee iD, disable the employee iD text box, and clear the remaining textboxes
            txtEmpID.Text = oEmployee.EmpID.ToString();
            txtEmpID.Enabled = false;
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtSSN.Text = "";
            txtDepartment.Text = "";
        }

        private void btnExistingEmp_Click(object sender, EventArgs e)
        {
            // event method body, declare and instantiate a variable of type employee called oEmployee
            // Retrieve the employee iD from the txtEmpID text box and pass it as an argument in the constructor. 
            // the int.Parse method converts the text to an integer data type
            Employee oEmployee = new Employee(int.Parse(txtEmpID.Text));

            // disable the employee iD textbox and fill in the remaining text boxes with the values of the Employee object’s properties:
            txtEmpID.Enabled = false;
            txtLoginName.Text = oEmployee.LoginName;
            txtPassword.Text = oEmployee.PassWord;
            txtSSN.Text = oEmployee.SSN.ToString();
            txtDepartment.Text = oEmployee.Department;
        }

        private void btnUpdateSI_Click(object sender, EventArgs e)
        {
            // declare and instantiate a variable of type employee called oEmployee
            Employee oEmployee = new Employee();    // this Employee constructor is for new employee

            // call the Update method, passing the values of the login name and password from 
            // the text boxes.show the method return message to the user in a message box
            MessageBox.Show(oEmployee.Update(txtLoginName.Text, txtPassword.Text));
            // Update the login name and password text boxes with the property values of the Employee object
            txtLoginName.Text = oEmployee.LoginName;
            txtPassword.Text = oEmployee.PassWord;
        }

        private void btnUpdateHR_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee(int.Parse(txtEmpID.Text));    // this Employee constructor is for exsiting employee
            MessageBox.Show(oEmployee.Update(int.Parse(txtSSN.Text), txtDepartment.Text));
            txtSSN.Text = oEmployee.SSN.ToString();
            txtDepartment.Text = oEmployee.Department;
        }
    }
}
