using System;
using SystemUdviklingH5.Interface;
using SystemUdviklingH5.StrategyMethod;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Customer
{
    class PaymentMethod
    {
        private IPaymentStrategy paymentStrategy;

        public PaymentMethod(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void betal()
        {
            paymentStrategy.Pay();
        }
    }
}
