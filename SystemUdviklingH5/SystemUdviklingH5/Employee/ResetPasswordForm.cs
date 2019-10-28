using System;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Employee
{
    class ResetPasswordForm
    {
        private string loginname;        

        public ResetPasswordForm()
        {
            this.loginname = "Admin";           
        }

        public void ResetPassword(string employeeId)
        {
            
            if (this.loginname == employeeId)
            {
                Console.WriteLine("Congratulations, you did reset ur password!");
                Console.WriteLine("You can try to logge ind again - your new password is: Password1");

            }
            else
            {
                Console.WriteLine("Oops, are you sure you trying login in in right place?");
            }

        }

    }
}
