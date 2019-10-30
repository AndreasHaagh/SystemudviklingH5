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
            Console.WriteLine("PLease Enter your credit card number");
        }
    }
}
