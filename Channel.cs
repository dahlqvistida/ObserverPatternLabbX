using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternLabbX
{
    class Channel : IChannel
    {

        private List<Subscribers> subscribers = new List<Subscribers>();
        private int _newContent;

        public int ListOfVideos {

            get
            {
                return _newContent;
            }
            set
            {
                if (value > _newContent)
                {
                    Notice();
                }

                _newContent = value;
            }
        }

        public void Subscribe(Subscribers subscriberName)
        {
            subscribers.Add(subscriberName);

        }

        public void UnSubscribe(Subscribers subscriberName)
        {
            subscribers.Remove(subscriberName);
        } 
        public void Notice()
        {
            //För varje subscriber som är inlagd i subscribers så skall de bli uppdaterade om ny information
            foreach  (var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
