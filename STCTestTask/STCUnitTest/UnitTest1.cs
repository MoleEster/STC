using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STCTestTask;
using STCTestTaskTwo;
using STCTestTaskTwo.Классы;

namespace STCUnitTest
{
    [TestClass]
    public class UnitTestTaskOne
    {
        [TestMethod]
        public void TestEncryption()
        {
            string answer = "TikvMxHTfuw";
            Assert.AreEqual(answer, STCTestTask.Program.Encrypt("ThisIsA&%#^-Test", "abcdefh"));
        }
        [TestMethod]
        public void TestEnumerableEncryption()
        {
            string[] word = new string[] { "This", "Is", "A", "Test" };
            string answer = "";
            foreach (string item in CollectionExceptions.Encrypt(word, "abcdefh"))
            {
                answer += item;
            }
            Assert.AreEqual(answer, "TikvMxHTfuw");
        }
        [TestMethod]
        public void TestDencryption()
        {
            string answer = "ThisIsATest";
            Assert.AreEqual(answer, STCTestTask.Program.Dencrypt("TikvMxHTfuw", "abcdefh"));
        }
        [TestMethod]
        public void TestEnumerableDencryption()
        {
            string[] word = new string[] { "Tikv", "Mx", "H", "Tfuw" };
            string answer = "";
            foreach (string item in CollectionExceptions.Dencrypt(word, "abcdefh"))
            {
                answer += item;
            }
            Assert.AreEqual(answer, "ThisIsATest");
        }

    }
    [TestClass]
    public class UnitTestTaskTwo
    {
        [TestMethod]
        public void TestMessage()
        {
            IMessage message = new Message()
            {
                Sender = "me",
                Recipient = "friend",
                Content = "Hi, my name is Jame",
                Title = "Hello"
            };

        }
        [TestMethod]
        public void TestSubscriber()
        {
            ISubscriber subscriber = new Subscriber()
            {
                Username = "Jame"
            };
            ISubscriber subscriber2 = new Subscriber()
            {
                Username = "Ash"
            };
            Assert.AreEqual(2, subscriber2.ID);
            subscriber.Subscribe(subscriber2);
            Assert.AreEqual(1, subscriber.amountOfSubscribers);

        }

    }

}
