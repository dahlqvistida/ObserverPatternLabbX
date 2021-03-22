using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternLabbX
{
    interface IChannel
    {
        void Subscribe(Subscribers subscriberName);
        void UnSubscribe(Subscribers subscriberName);
        void Notice();
    }
}
