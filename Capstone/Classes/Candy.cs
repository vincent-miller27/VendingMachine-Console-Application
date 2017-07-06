using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Candy : VendingMachineItem
    {
        public Candy(string itemName, int quantity, double price) : base(itemName, quantity, price)
        {
        }

        public override string DisplayMessage()
        {
            return "Munch Munch, Yum!";
        }
    }
}
