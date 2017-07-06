using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        private Dictionary<string, VendingMachineItem> vendingDictionary = new Dictionary<string, VendingMachineItem>();
        private double balance = 0.00;
        private double totalSales = 0;
         
        public VendingMachine()
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, fileName);

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] itemArray = line.Split('|');

                        if (itemArray[0].StartsWith("A"))
                        {
                            vendingDictionary[itemArray[0]] = new Chips(itemArray[1], 5, double.Parse(itemArray[2]));
                        }
                        else if (itemArray[0].StartsWith("B"))
                        {
                            vendingDictionary[itemArray[0]] = new Candy(itemArray[1], 5, double.Parse(itemArray[2]));
                        }
                        else if(itemArray[0].StartsWith("C"))
                        {
                            vendingDictionary[itemArray[0]] = new Soda(itemArray[1], 5, double.Parse(itemArray[2]));
                        }
                        else
                        {
                            vendingDictionary[itemArray[0]] = new Gum(itemArray[1], 5, double.Parse(itemArray[2]));
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("There's an error!");
                Console.WriteLine(e.Message);
            }
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

        public double TotalSales
        {
            get
            {
                return totalSales;
            }
            set
            {
                totalSales = value;
            }
        }


        public Dictionary<string, VendingMachineItem> VendingDictionary
        {
            get
            {
                return vendingDictionary;
            }
        }
    }
}
