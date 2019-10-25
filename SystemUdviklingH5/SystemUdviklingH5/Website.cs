using System;
using SystemUdviklingH5.Customer;

namespace SystemUdviklingH5
{
    class Website
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("velkommen til lagekagehuset nye system. (Dette er en midlertige løsning og det vil blive rykket over på en hjemmeside senere)");

            var input = Console.ReadLine();

            if (input.ToLower() == "buy") // Kan ikke lide æøå så derfor går vi med englesk
            {
                DisplayProductCataloge();
            }
            else if (input.ToLower() == "login")
            {
                DisplayLoginForm();
            }
            else
            {
                Console.WriteLine("input not vaild");
            }
        }

        private static void DisplayProductCataloge()
        {
            Console.WriteLine("Hello productCataloge");
            Console.ReadKey();
            var productCataloge = new ProductCataloge();
            productCataloge.ShowProductCataloge();
        }

        public static void DisplayLoginForm()
        {
            Console.WriteLine("Hello login");
            Console.ReadKey();
        }
    }
}
