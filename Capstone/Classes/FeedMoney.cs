using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class FeedMoney
    {
        private double balance;

        public FeedMoney()
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

        public double TakeMoney(double moneyIn, double newBalance)
        {
            newBalance += moneyIn;

            balance = newBalance;

            return balance;
        }

    }
}
