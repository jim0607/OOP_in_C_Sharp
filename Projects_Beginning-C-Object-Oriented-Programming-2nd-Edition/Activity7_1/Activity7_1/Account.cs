using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_1
{
    class Account
    {
        // create the private instance variable  (private is the default modifier for instance variables)
        int _accountNumber;

        // add the GetBalance method to the class definition
        public double GetBalance(int accountNumber)
        {
            _accountNumber = accountNumber;
            if (_accountNumber == 1)
            {
                return 1000;
            }
            else if (_accountNumber == 2)
            {
                return 2000;
            }
            else
            {
                return -1;
            }
        }
    }
    class CheckingAccount: Account
    {

    }
    class SavingAccount: Account
    {

    }
}
