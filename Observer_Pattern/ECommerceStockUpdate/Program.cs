// See https://aka.ms/new-console-template for more information
using ECommerceStockUpdate.Observable;
using ECommerceStockUpdate.Observer;

namespace ECommerceStockUpdate;

public static class Program
{
    static void Main(String[] args)
    {
        IStockObservable stockObservable = new IphoneObservable();

        INotificationAlertObserver notificationAlertObserver1 = new EmailAlertObserver("xyz1@gmail.com", stockObservable);
        INotificationAlertObserver notificationAlertObserver2 = new EmailAlertObserver("xyz2@gmail.com", stockObservable);
        INotificationAlertObserver notificationAlertObserver3 = new MobileAlertObserver("xyz3@gmail.com", stockObservable);

        stockObservable.Add(notificationAlertObserver1);
        stockObservable.Add(notificationAlertObserver2);
        stockObservable.Add(notificationAlertObserver3);

        stockObservable.SetStockCount(10);

        Console.ReadLine();
    }
}
