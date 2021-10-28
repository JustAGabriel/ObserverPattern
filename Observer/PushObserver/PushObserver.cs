using ObserverPattern.Observer;
using System;
using System.Text.Json;

namespace ObserverPattern
{
    class PushObserver : IPushObserver
    {
        public ISubject subject { get; set; }

        public PushObserver(ISubject sub) => subject = sub;

        public void Update(ISubject subject)
        {
            Console.WriteLine("I received the following data:");
            Console.WriteLine(JsonSerializer.Serialize(subject));
        }
    }
}
