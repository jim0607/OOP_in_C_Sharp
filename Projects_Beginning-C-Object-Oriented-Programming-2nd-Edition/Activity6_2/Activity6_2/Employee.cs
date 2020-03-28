using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity6_2
{
    class Employee
    {
        private int _empID;
        private string _loginName;
        private string _passWord;
        private int _SSN;
        private string _department;

        public int EmpID
        {
            get { return _empID; }
        }
        
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
       
        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
       
        public int SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
       
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        private int GetNextID()
        {
            return 100;
        }

        // create a default default class constructor, and add code that calls the GetNextID method and 
        // assigns the return value to the private instance variable _empID
        public Employee()               // constructor for new employee
        {
            _empID = GetNextID();
        }
        // Overload the default constructor method by adding a second constructor method that 
        // takes an integer parameter of empID, like so
        public Employee(int empID)      // constructor for existing employee
        {
            if (empID == 1)
            {
                _empID = empID;
                LoginName = "Smith";
                PassWord = "js";
                SSN = 26936;
                Department = "Physics";
            }
            else if (empID == 2)
            {
                _empID = empID;
                LoginName = "Jones";
                PassWord = "jr";
                SSN = 345134;
                Department = "Engineering";
            }
            else
            {
                throw new Exception("Invalid employee id");
            }
        }

        // add the following Update method to the Employee class. this method simulates the updating of the employee security information
        public string Update(string loginname, string password)
        {
            LoginName = loginname;
            PassWord = password;
            return "Security information updated";
        }
        // Overloading a Class Method
        // add a second Update method to simulate the updating of the employee human resources data
        public string Update(int ssNumber, string department)
        {
            SSN = ssNumber;
            Department = department;
            return "HR info updated.";
        }
    }
}
