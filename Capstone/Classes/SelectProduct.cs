using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class SelectProduct
    {
        private double balance;
        private double totalSale;

        public SelectProduct()
        {

        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public double TotalSale
        {
            get
            {
                return totalSale;
            }
            set
            {
                totalSale = value;
            }
        }

        public double MakeSelection(string product, double newBalance, VendingMachineItem entry, double totalSales)
        {
            try
            {
                if (newBalance >= entry.Price && entry.Quantity >= 1)
                {
                    newBalance -= entry.Price;

                    totalSales += entry.Price;

                    entry.Quantity -= 1;

                    totalSale = totalSales;


                    Console.WriteLine();
                    Console.WriteLine("Vending!");
                    Console.WriteLine(entry.DisplayMessage());
                    Console.WriteLine();
                }
                else if (entry.Quantity < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sold Out!");
                    Console.WriteLine("Please make another selection");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please insert more money!");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Entry not valid, please try again!");
                Console.WriteLine();
            }

            balance = newBalance;

            return balance;
        }  
    }
}
