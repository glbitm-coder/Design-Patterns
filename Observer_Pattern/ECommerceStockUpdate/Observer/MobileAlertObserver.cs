using System;
using ECommerceStockUpdate.Observable;

namespace ECommerceStockUpdate.Observer
{

    public class MobileAlertObserver : INotificationAlertObserver
    {
        string _emailId;
        IStockObservable _stockObservable;

        public MobileAlertObserver(string emailId, IStockObservable stockObservable)
        {
            _emailId = emailId;
            _stockObservable = stockObservable;
        }

        public void update()
        {
            sendMsgOnMobile(_emailId, "Product is in stock. Hurry up!!");
        }

        private void sendMsgOnMobile(string emailId, string message)
        {
            Console.WriteLine("Msg sent to:" + emailId);
        }
    }
}
