﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Chips : VendingMachineItem
    {
        public Chips(string itemName, int quantity, double price) : base(itemName, quantity, price)
        {
        }

        public override string DisplayMessage()
        {
            return "Crunch Crunch, Yum!";
        }
    }
}
