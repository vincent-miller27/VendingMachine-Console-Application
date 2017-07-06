using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class SelectProductTest
    {
        [TestMethod]
        public void MakeSelectionTest1()
        {
            VendingMachine machine = new VendingMachine();
            SelectProduct test = new SelectProduct();

            test.MakeSelection("B3", 10.00, machine.VendingDictionary["B3"], 0.00);

            Assert.AreEqual(8.50, test.Balance);
        }

        [TestMethod]
        public void MakeSelectionTest2()
        {
            VendingMachine machine = new VendingMachine();
            SelectProduct test = new SelectProduct();

            test.MakeSelection("B3", 10.00, machine.VendingDictionary["B3"], 0.00);

            Assert.AreEqual(1.50, test.TotalSale);
        }

        [TestMethod]
        public void MakeSelectionTest3()
        {
            VendingMachine machine = new VendingMachine();
            SelectProduct test = new SelectProduct();

            test.MakeSelection("B3", 10.00, machine.VendingDictionary["B3"], 0.00);
            test.MakeSelection("B3", 8.50, machine.VendingDictionary["B3"], 1.50);

            Assert.AreEqual(3.00, test.TotalSale);
            Assert.AreEqual(7.00, test.Balance);
        }
    }
}
