using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class DisplayItems
    {
        public void ShowItems(VendingMachine vend)
        {
            Console.WriteLine();
            Console.WriteLine("{0, -15} {1, -20} {2, -15} {3: 0.00}", "Slot Number", "Product", "Quantity", "Price $");
            Console.WriteLine("-------------------------------------------------------------");
            foreach (KeyValuePair<string, VendingMachineItem> kvp in vend.VendingDictionary)
            {
                if (kvp.Value.Quantity == 0)
                {
                    Console.WriteLine("{0, -15} {1, -20} {2, -15} ${3: 0.00}", kvp.Key, kvp.Value.ItemName, "SOLD OUT", kvp.Value.Price);
                }
                else
                {
                    Console.WriteLine("{0, -15} {1, -20} {2, -15} ${3: 0.00}", kvp.Key, kvp.Value.ItemName, kvp.Value.Quantity, kvp.Value.Price);
                }
            }

            Console.WriteLine();
        }
    }
}
