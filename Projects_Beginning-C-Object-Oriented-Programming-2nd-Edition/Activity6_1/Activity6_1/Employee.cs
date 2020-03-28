using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6_1
{
    class Employee
    {
        // add private instance variables
        private int _empID;
        private string _loginName;
        private string _password;
        private int _securityLevel;
        public int EmployeeID
        {
            get { return _empID; }
        }
        /*  add public properties to access the private instance variables
            Newcomers to OOP often ask why it’s necessary to go through so much work to get and set properties. 
            Couldn’t you just create public instance variables that the user could read and write to directly? 
            The answer lies in one of the fundamental tenets of OOP: encapsulation.
            Encapsulation means that the client code does not have direct access to the data.
            When working with the data, the client code must use clearly defined properties and methods accessed
            through an instance of the class */
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }
        public int SecurityLevel
        {
            get { return _securityLevel; }
        }
        // add the a Login method to the class
        public Boolean Login(string loginname, string password)
        {
            LoginName = loginname;
            PassWord = password;
            if (loginname == "Smith" & password == "js")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else if (loginname == "Jones" & password == "mj")
            {
                _empID = 2;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
