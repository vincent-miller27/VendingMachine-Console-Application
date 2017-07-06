using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class GiveChangeTest
    {
        [TestMethod]
        public void MakeChangeTestInitial()
        {
            GiveChange test = new GiveChange();

            test.MakeChange(5.67);

            Assert.AreEqual(0, test.Balance);
        }

        [TestMethod]
        public void MakeChangeTestChangeDue()
        {
            GiveChange test = new GiveChange();

            test.MakeChange(5.67);

            Assert.AreEqual(5.67, test.ChangeDue, 0.0001);
        }

        [TestMethod]
        public void MakeChangeTestQuarters()
        {
            GiveChange test = new GiveChange();

            test.MakeChange(5.25);

            Assert.AreEqual(21, test.Quarters);
        }

        [TestMethod]
        public void MakeChangeTestPennies()
        {
            GiveChange test = new GiveChange();

            test.MakeChange(5.69);

            Assert.AreEqual(4, test.Pennies);
        }

        [TestMethod]
        public void MakeChangeTestOthers()
        {
            GiveChange test = new GiveChange();

            test.MakeChange(5.40);

            Assert.AreEqual(1, test.Nickles);

            Assert.AreEqual(1, test.Dimes);
        }
    }
}
