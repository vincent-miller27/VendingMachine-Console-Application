using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Interfaces
{
    public class UserInterface
    {
        private bool finishedProgram;
        VendingMachine vend = new VendingMachine();
        DisplayItems display = new DisplayItems();
        SalesReport salesReport = new SalesReport();

        public UserInterface(VendingMachine thisVendingMachine)
        {
            vend = thisVendingMachine;
        }

        public void Run()
        {

            while (finishedProgram == false)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) Print Sales Report");
                Console.WriteLine("(4) End Program");
                Console.WriteLine("-----------------------------------");
                Console.Write("Please select an option: ");
                string entry = Console.ReadLine();

                switch (entry)
                {
                    case "1":
                        display.ShowItems(vend);
                        break;
                    case "2":
                        PurchaseInterface purchaseInterface = new PurchaseInterface(vend);
                        purchaseInterface.RunPurchaseInterface();
                        finishedProgram = false;
                        break;
                    case "3":
                        salesReport.PrintReport(vend);
                        break;
                    case "4":
                        finishedProgram = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please make a valid selection");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
