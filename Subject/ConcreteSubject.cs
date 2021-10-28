using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Subject
{
    class ConcreteSubject : ISubject
    {
        public string Message { get; set; }

        List<IPullObserver> _pullObservers { get; set; }
        List<IPushObserver> _pushObservers { get; set; }

        public ConcreteSubject()
        {
            this._pullObservers = new List<IPullObserver>();
            this._pushObservers = new List<IPushObserver>();
        }

        public void NotifyObservers()
        {
            this._pullObservers.ForEach(x => x.Update());
            this._pushObservers.ForEach(x => x.Update(this));
        }

        public void RegisterObserver(IPullObserver observer)
        {
            this._pullObservers.Add(observer);
        }

        public void RegisterObserver(IPushObserver observer)
        {
            this._pushObservers.Add(observer);
        }

        public bool RemoveObserver(IPullObserver observer)
        {
            bool removed = false;

            for (int i = 0; i < this._pullObservers.Count; i++)
            {
                if (this._pullObservers[i].Equals(observer))
                {
                    this._pullObservers.RemoveAt(i);
                    removed = true;
                    break;
                }
            }

            return removed;
        }

        public bool RemoveObserver(IPushObserver observer)
        {
            bool removed = false;

            for (int i = 0; i < this._pushObservers.Count; i++)
            {
                if (this._pushObservers[i].Equals(observer))
                {
                    this._pushObservers.RemoveAt(i);
                    removed = true;
                    break;
                }
            }

            return removed;
        }
    }
}
