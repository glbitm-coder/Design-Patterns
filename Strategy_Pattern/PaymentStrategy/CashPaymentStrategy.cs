using System;

namespace PaymentStrategy
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
        }
    }
}