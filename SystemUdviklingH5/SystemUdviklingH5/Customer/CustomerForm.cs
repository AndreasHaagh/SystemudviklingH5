using System;
using SystemUdviklingH5.Models;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Customer
{
    class CustomerForm
    {
        public static List<Product> choosenProducts = new List<Product>();

        public static void showCustomerForm()
        {
            Console.Clear();
            Console.WriteLine("Dine udvalgte vare");
            foreach (var item in choosenProducts)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
