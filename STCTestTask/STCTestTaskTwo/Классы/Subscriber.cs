using System;
using System.Collections.Generic;

namespace STCTestTaskTwo.Классы
{
    public sealed class Subscriber : ISubscriber
    {
        private List<int> subscribers = new List<int>();
        private static int i = 0;

        private int index;

        public int ID { get => index; }

        public string Username { get; set; }

        public int amountOfSubscribers { get => subscribers.Count ; }

        public Subscriber()
        {
            i++;
            this.index = i;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (this.Username != subscriber.Username && !subscribers.Contains(subscriber.ID))
            {
                Console.WriteLine("{0} subscribed on {1} at {2}", subscriber.Username, this.Username, DateTime.Now);
                subscribers.Add(subscriber.ID);
            }
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (this.Username != subscriber.Username && subscribers.Contains(subscriber.ID))
            {
                Console.WriteLine("{0} unsubscribed {1} at {2}", subscriber.Username, this.Username, DateTime.Now);
                subscribers.Remove(subscriber.ID);
            }
        }
    }
}
