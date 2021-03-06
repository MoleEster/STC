﻿using System;

namespace STCTestTaskTwo
{
    public interface IMessage
    {
        string Sender { get; set; }

        string Recipient { get; set; }

        string Title { get; set; }

        string Content { get; set; }

        DateTime dateTime { get; }

    }
}
