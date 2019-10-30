using System;
using SystemUdviklingH5.Customer;
using SystemUdviklingH5.Employee;

namespace SystemUdviklingH5
{
    class Website
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool alive = true;

            while (alive)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Velkommen til lagekagehuset nye system.");
                Console.WriteLine("Dette er en midlertige løsning og det vil blive rykket over på en hjemmeside senere");

                //menu with options to choose 
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n1. Buy \t 2. Log in  \t 3.Close Shop");                
                Console.Write("Enter number of choice:");
                Console.ForegroundColor = color;
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            DisplayProductCataloge();
                            break;
                        case 2:
                            DisplayLoginForm();
                            break;
                        case 3:
                            alive = false;
                            continue;
                        default:
                            Console.WriteLine("input not vaild");
                            break;
                    }
                    //DoSomething();
                }
                catch (Exception ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }
        }
         

        private static void DisplayProductCataloge()
        {
            Console.WriteLine("Hello Customer");            
            var productCataloge = new ProductCataloge();
            productCataloge.ShowProductCataloge();
        }

        public static void DisplayLoginForm()
        {
            Console.WriteLine("Hello, please log in!");
            var login = new LoginForm();
            login.Login();
           
        }
    }
}
