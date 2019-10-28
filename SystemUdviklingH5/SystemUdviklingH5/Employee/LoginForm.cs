using System;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Employee
{
    class LoginForm
    {
        private string employeeId;
        private string password;

        public LoginForm()
        {
            this.employeeId = "Admin";
            this.password = "Password1";
        }

        public void Login()
        {
            Console.WriteLine("Please, enter ur loginname: ");
            string employeeId = Console.ReadLine();
            Console.WriteLine("Please, enter ur password: ");
            string password = Console.ReadLine();
            if (this.employeeId == employeeId && this.password == password)
            {
                Console.WriteLine("Tillykke, du har logget ind!");
            }
            else
            {
                Console.WriteLine("Either ur login or password are wrong!");
                Console.WriteLine("please reset ur password:");
                DisplayResetPasswordForm();
            }
            
        }

        public void DisplayResetPasswordForm()
        {
            Console.WriteLine("Please, enter ur loginname: ");
            string loginname = Console.ReadLine();
            if (this.employeeId == loginname)
            {
                Console.WriteLine("Congratulations, you did reset ur password!");
                Console.WriteLine("You can try to logge ind again - your new password is: Password1");

            } else
            {
                Console.WriteLine("Oops, are you sure you trying login in in right place?");               
            }
           
        }


        
    }
}
