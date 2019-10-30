using System;
using SystemUdviklingH5.Interface;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.StrategyMethod
{
    class MobilPayPayment : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("Please pay to this phone number: + 45 88 88 88 88");
            Console.WriteLine("Thank you for your order!");           
           
        }
    }
}
