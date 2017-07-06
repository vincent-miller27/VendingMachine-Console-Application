using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.Collections.Generic;

namespace CapstoneTests
{
    [TestClass]
    public class DictionaryTest
    {
        [TestMethod]
        public void VendingMachineTestItem()
        {
            VendingMachine dictionary = new VendingMachine();

            Assert.AreEqual("Potato Crisps", dictionary.VendingDictionary["A1"].ItemName);
        }

        [TestMethod]
        public void VendingMachineTestQuantity()
        {
            VendingMachine dictionary = new VendingMachine();

            Assert.AreEqual(5, dictionary.VendingDictionary["A1"].Quantity);

            SelectProduct test = new SelectProduct();

            test.MakeSelection("B3", 10.00, dictionary.VendingDictionary["B3"], 0.00);

            Assert.AreEqual(4, dictionary.VendingDictionary["B3"].Quantity);
        }

        [TestMethod]
        public void VendingMachineTestPrice()
        {
            VendingMachine dictionary = new VendingMachine();

            Assert.AreEqual(3.05, dictionary.VendingDictionary["A1"].Price, 0.0001);
        }
    }
}
