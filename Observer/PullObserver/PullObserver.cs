using ObserverPattern.Observer;
using System;
using System.Text.Json;

namespace ObserverPattern.Subject
{
    class PullObserver : IPullObserver
    {
        public ISubject subject { get; set; }

        public PullObserver(ISubject sub) => subject = sub;

        public void Update()
        {
            Console.WriteLine("I pulled the following data:");
            Console.WriteLine(JsonSerializer.Serialize(subject));
        }
    }
}
