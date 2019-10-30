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
            Console.WriteLine("Please, enter confirmation code that you received: ");
            string confirmationCode = Console.ReadLine();

            while(confirmationCode.Length != 4 )
            {
                Console.WriteLine("Please, enter correct confirmation code: ");
                confirmationCode = Console.ReadLine();
            }             
             Console.WriteLine("Thank you for your order!");   
            
                    
           
        }
    }
}
