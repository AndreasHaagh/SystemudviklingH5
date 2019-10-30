using System;
using SystemUdviklingH5.Interface;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.StrategyMethod
{
    class CreditCardPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("You can pay with: \n1.Visa \t2.MasterCard \t3.Dankort");
            Console.WriteLine("PLease, Enter your credit card number: ");
            string creditCardNumber = Console.ReadLine();
            while (creditCardNumber.Length != 16)
            {
                Console.WriteLine("PLease, Enter correct credit card number: ");
                creditCardNumber = Console.ReadLine();
            } 
            
             Console.WriteLine("Please, enter cvc:");
             string cardCvc = Console.ReadLine();
            while(cardCvc.Length != 3)
            {
                Console.WriteLine("Please, enter cvc: ");
            }

            Console.WriteLine("Payment success! Thank you for ur purchase!");
        }
    }
}
