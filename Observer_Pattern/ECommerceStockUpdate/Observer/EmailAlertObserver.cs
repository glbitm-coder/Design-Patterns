using System;
using ECommerceStockUpdate.Observable;

namespace ECommerceStockUpdate.Observer
{
    public class EmailAlertObserver : INotificationAlertObserver
    {
        string _emailId;
        IStockObservable _stockObservable;
        
        public EmailAlertObserver(string emailId, IStockObservable stockObservable)
        {
            _emailId = emailId;
            _stockObservable = stockObservable;
        }

        public void update()
        {
            sendMail(_emailId, "Product is in stock. Hurry up!!");
        }

        private void sendMail(string emailId, string message)
        {
            Console.WriteLine("Mail sent to:" + emailId);
        }
    }
}