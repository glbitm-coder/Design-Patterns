using ECommerceStockUpdate.Observer;
using System;

namespace ECommerceStockUpdate.Observable
{
    public class IphoneObservable : IStockObservable
    {
        public List<INotificationAlertObserver> observerList = new();
        int stockCount = 0;
        public void Add(INotificationAlertObserver observer)
        {
            observerList.Add(observer);
        }

        public int GetStockCount()
        {
            return stockCount;
        }

        public void NotifySubscribers()
        {
            foreach(INotificationAlertObserver observer in observerList)
            {
                observer.update();
            }
        }

        public void Remove(INotificationAlertObserver observer)
        {
            observerList.Remove(observer);   
        }

        public void SetStockCount(int count)
        {
            if(stockCount == 0)
            {
                NotifySubscribers();
            }
            stockCount = count;
        }
    }
}