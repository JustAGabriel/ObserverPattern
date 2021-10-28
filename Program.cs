using System;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new ConcreteSubject();
            subject.Message = "Hello the the observers!";

            IPullObserver pullObserver = new PullObserver(subject);
            subject.RegisterObserver(pullObserver);

            IPushObserver pushObserver = new PushObserver(subject);
            subject.RegisterObserver(pushObserver);

            subject.NotifyObservers();
        }
    }
}
