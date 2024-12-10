using System;

namespace PaymentStrategy
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}