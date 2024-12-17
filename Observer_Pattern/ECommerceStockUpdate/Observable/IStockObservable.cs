using ECommerceStockUpdate.Observer;
using System;

namespace ECommerceStockUpdate.Observable
{
    public interface IStockObservable
    {
        void Add(INotificationAlertObserver observer);
        void Remove(INotificationAlertObserver observer);
        void NotifySubscribers();
        void SetStockCount(int count);
        int GetStockCount();
    }
}