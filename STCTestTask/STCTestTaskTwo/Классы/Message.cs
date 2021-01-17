using System;

namespace STCTestTaskTwo
{
    internal sealed class Message : IMessage
    {
        public string Sender { get; set; }

        public string Recipient { get; set; }

        public string Title { get; set ; }

        public string Content { get ; set; }

        public DateTime dateTime => DateTime.Now;
    }
}
