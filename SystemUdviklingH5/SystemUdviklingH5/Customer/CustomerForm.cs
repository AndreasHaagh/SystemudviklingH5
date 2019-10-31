using System;
using SystemUdviklingH5.Models;
using SystemUdviklingH5.Interface;
using SystemUdviklingH5.StrategyMethod;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Customer
{
    class CustomerForm
    {
        public static List<Product> choosenProducts = new List<Product>();

        private static PaymentMethod creditCard = new PaymentMethod(new CreditCardPayment());
        private static PaymentMethod mobilPay = new PaymentMethod(new MobilPayPayment());

        public static void ShowCustomerForm()
        {
            Console.Clear();
            Console.WriteLine("Dine udvalgte vare");
            foreach (var item in choosenProducts)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine("For at betale skriv: confirm");
            var input = Console.ReadLine();
            if (input.ToLower() == "confirm")
            {
                ConfirmOrder(choosenProducts);
            }
        }

        public static void ConfirmOrder(List<Product> products)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Vælg en betailgns metode 1. Credit Card 2. MobilPay");
            var input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "1":
                    creditCard.Betal();
                    break;
                case "2":
                    mobilPay.Betal();
                    break;
            }
        }
    }
}
