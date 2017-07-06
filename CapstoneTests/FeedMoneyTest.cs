using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class FeedMoneyTest
    {
        [TestMethod]
        public void TakeMoneyTest1()
        {
            FeedMoney test = new FeedMoney();

            Assert.AreEqual(0, test.Balance);

            test.TakeMoney(10.00, 0);

            Assert.AreEqual(10.00, test.Balance);
        }

        [TestMethod]
        public void TakeMoneyTest2()
        {
            FeedMoney test = new FeedMoney();

            test.TakeMoney(10.00, 10.00);

            Assert.AreEqual(20.00, test.Balance);
        }

        [TestMethod]
        public void TakeMoneyTest3()
        {
            FeedMoney test = new FeedMoney();;

            test.TakeMoney(2.00, 3.69);

            Assert.AreEqual(5.69, test.Balance, 0.0001);
        }
    }
}
