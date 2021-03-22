using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternLabbX
{
    class Subscribers : ISubscribers
    {

        public string GiveSubscribersName { get; private set; }

        //För att kunna ge varje subscriber ett namn
        public Subscribers(string name)
        {
            GiveSubscribersName = name;
        }


        //När subscribers blir uppdaterade skickas detta medelande ut till alla som är subscribers.
        public void Update()
        {
            Console.WriteLine("Hello " + GiveSubscribersName + ", There is a new video published!");
        }
    }
}
