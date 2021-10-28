

using ObserverPattern.Observer;

namespace ObserverPattern
{
    interface ISubject
    {
        string Message { get; set; }

        void RegisterObserver(IPullObserver observer);
        bool RemoveObserver(IPullObserver observer);

        void RegisterObserver(IPushObserver observer);
        bool RemoveObserver(IPushObserver observer);
        
        void NotifyObservers();
    }
}
