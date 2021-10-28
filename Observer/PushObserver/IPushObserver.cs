namespace ObserverPattern.Observer
{
    interface IPushObserver
    {
        ISubject subject { get; set; }

        void Update(ISubject subject);
    }
}
