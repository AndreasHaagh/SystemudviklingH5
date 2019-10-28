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
                //DisplayOrderList();
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
            var reset = new ResetPasswordForm();
            reset.ResetPassword(loginname);
           
        }


        
    }
}
