using System;

namespace ObserverPatternLabbX
{
    class Program
    {
        static void Main(string[] args) 
        {
            Channel channel = new Channel();

            Subscribers subscriberName1 = new Subscribers("Batman");
            channel.Subscribe(subscriberName1);

            Subscribers subscriberName2 = new Subscribers("Ronja Rövardotter");
            channel.Subscribe(subscriberName2);

            Subscribers subscriberName3 = new Subscribers("Neviim");
            channel.Subscribe(subscriberName3);

            Subscribers subscriberName4 = new Subscribers("Diide");
            channel.Subscribe(subscriberName4);


            channel.ListOfVideos++;

            


        }
    }
}
