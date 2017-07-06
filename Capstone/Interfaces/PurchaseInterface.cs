using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Capstone.Classes;

namespace Capstone.Interfaces
{
    public class PurchaseInterface
    {
        private bool finishedPurchase;
        private double moneyIn = 0.00;
        private string product = "";
        VendingMachine vend = new VendingMachine();
        FeedMoney feedMoney = new FeedMoney();
        SelectProduct selectProduct = new SelectProduct();
        GiveChange giveChange = new GiveChange();
        LogMethod logMethod = new LogMethod();

        public PurchaseInterface(VendingMachine thisVendingMachine)
        {
            vend = thisVendingMachine;
        }

        public void RunPurchaseInterface()
        {
            Console.WriteLine();

            while (finishedPurchase == false)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine($"Current Money Provided: ${vend.Balance: 0.00}");
                Console.WriteLine("---------------------------------");
                Console.Write("Please select an option: ");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("This machine only takes $1.00, $2.00, $5.00 or $10.00 at a time");
                            Console.Write("Enter amount of money:  $");
                            moneyIn = double.Parse(Console.ReadLine());
                            feedMoney.TakeMoney(moneyIn, vend.Balance);
                            vend.Balance = feedMoney.Balance;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Please enter a valid dollar amount.");
                            Console.WriteLine();
                        }
                        logMethod.WriteToLog("FEED MONEY:", moneyIn, vend.Balance);
                        finishedPurchase = false;
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Please select a product: ");
                            product = Console.ReadLine().ToUpper();
                            selectProduct.MakeSelection(product, vend.Balance, vend.VendingDictionary[product], vend.TotalSales);
                            vend.Balance = selectProduct.Balance;
                            vend.TotalSales = selectProduct.TotalSale;
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Please enter valid selection.");
                            Console.WriteLine();
                        }
                        logMethod.WriteToLog($"{product}: {vend.VendingDictionary[product].ItemName}", vend.Balance + vend.VendingDictionary[product].Price, vend.Balance);
                        finishedPurchase = false;
                        break;
                    case "3":
                        giveChange.MakeChange(vend.Balance);
                        vend.Balance = giveChange.Balance;
                        logMethod.WriteToLog("GIVE CHANGE:", giveChange.ChangeDue, vend.Balance);
                        finishedPurchase = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please make a valid selection");
                        Console.WriteLine();
                        finishedPurchase = false;
                        break;
                }
            }
        }
    }
}
