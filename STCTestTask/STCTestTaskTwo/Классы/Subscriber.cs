using System;

namespace STCTestTaskTwo.Классы
{
    internal sealed class Subscriber : ISubscriber
    {
        private static int i = 0;

        private int index;

        public int ID { get => index; }

        public string Username { get; set; }

        public int amountOfSubscribers { get => _amountOfSubscribers ; }

        private int _amountOfSubscribers = 0;

        public Subscriber()
        {
            i++;
            this.index = i;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _amountOfSubscribers++;
            Console.WriteLine("{0} subscribed on {1} at {2}", subscriber.Username,this.Username, DateTime.Now);
        }
    }
}
