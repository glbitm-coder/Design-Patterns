// See https://aka.ms/new-console-template for more information

namespace PaymentStrategy;
class Program
{
    static void Main(string[] args)
    {
        //Ask the user to Select the Payment Type
        Console.WriteLine("Please Select Payment Type : \n1 For CreditCard \n2 For DebitCard \n3 For Cash");

        int SelectedPaymentType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Payment type is : " + SelectedPaymentType);
        Console.WriteLine("\nPlease enter Amount to Pay : ");

        double Amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Amount is : " + Amount);

        PaymentContext paymentContext = new PaymentContext();

        if (SelectedPaymentType == (int)PaymentType.DebitCard)
        {
            paymentContext.SetPaymentStrateggy(new DebitCardPaymentStrategy());
        }
        else if (SelectedPaymentType == (int)PaymentType.CreditCard)
        {
            paymentContext.SetPaymentStrateggy(new CreditCardPaymentStrategy());
        }
        else if (SelectedPaymentType == (int)PaymentType.Cash)
        {
            paymentContext.SetPaymentStrateggy(new CashPaymentStrategy());
        }
        else
        {
            Console.WriteLine("You Select an Invalid Option");
        }

        paymentContext.Pay(Amount);

        Console.Read();
    }
}