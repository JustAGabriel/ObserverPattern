using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    interface IPullObserver
    {
        ISubject subject { get; set; }

        void Update();
    }
}
