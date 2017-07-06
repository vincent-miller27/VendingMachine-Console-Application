using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachineItem
    {
        private string itemName;
        private int quantity = 0;
        private double price = 0;


        public VendingMachineItem(string itemName, int quantity, double price)
        {
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
        }


        public string ItemName
        {
            get
            {
                return itemName;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public virtual string DisplayMessage()
        {
            return "";
        }
    }
}
