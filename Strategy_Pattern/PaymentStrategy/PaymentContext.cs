using System;

namespace PaymentStrategy
{
    public class PaymentContext
    {
        private IPaymentStrategy? _paymentStrategy;

        public void SetPaymentStrateggy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Pay(double amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}