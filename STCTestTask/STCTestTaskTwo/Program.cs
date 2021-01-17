using System;
using STCTestTaskTwo.Классы;

namespace STCTestTaskTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message()
            {
                Sender = "me",
                Recipient = "friend",
                Content = "Hi, my name is Jame",
                Title = "Hello"
            };
            Post(message);
            Console.ReadLine();

            Subscriber subscriber = new Subscriber()
            {
                Username = "Jame"
            };
            Subscriber subscriber2 = new Subscriber()
            {
                Username = "Ash"
            };
            subscriber.Subscribe(subscriber2);
            Console.ReadLine();
        }

        public static void Post(IMessage message) 
        {
            Console.WriteLine("{0}\nFrom: {1}\nTo: {2}\nTitle: {3}\n{4}"
                ,message.dateTime
                ,message.Sender
                ,message.Recipient
                ,message.Title
                ,message.Content);
        }
    }
}
