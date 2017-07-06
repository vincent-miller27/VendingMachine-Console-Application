using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class GiveChange
    {
        private double balance;
        private int quarters = 0;
        private int dimes = 0;
        private int nickles = 0;
        private int pennies = 0;
        private double changeDue;

        public GiveChange()
        {

        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Quarters
        {
            get { return quarters; }
            set { quarters = value; }
        }

        public int Dimes
        {
            get { return dimes; }
            set { dimes = value; }
        }

        public int Nickles
        {
            get { return nickles; }
            set { nickles = value; }
        }

        public int Pennies
        {
            get { return pennies; }
            set { pennies = value; }
        }

        public double ChangeDue
        {
            get { return changeDue; }
            set { changeDue = value; }
        }

        public double MakeChange(double newBalance)
        {
            while (newBalance >= 0.25)
            {
                changeDue += 0.25;
                newBalance -= 0.25;
                newBalance = Math.Round(newBalance, 2);
                quarters += 1;
            }
            while (newBalance >= 0.10)
            {
                changeDue += 0.10;
                newBalance -= 0.10;
                newBalance = Math.Round(newBalance, 2);
                dimes += 1;
            }
            while (newBalance >= 0.05)
            {
                changeDue += 0.05;
                newBalance -= 0.05;
                newBalance = Math.Round(newBalance, 2);
                nickles += 1;
            }
            while (newBalance >= 0.01)
            {
                changeDue += 0.01;
                newBalance -= 0.01;
                newBalance = Math.Round(newBalance, 2);
                pennies += 1;
            }
            balance = newBalance;

            Console.WriteLine();
            Console.WriteLine($"Your change due is ${ChangeDue: 0.00}");
            Console.WriteLine($"Your change is returned in {Quarters} quarter(s), {Dimes} dime(s), {Nickles} nickle(s) and {Pennies} pennie(s)");
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            return balance;
        }
    }
}
