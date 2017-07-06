using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;
using Capstone.Interfaces;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine test = new VendingMachine();

            UserInterface thisUserInterface = new UserInterface(test);

            thisUserInterface.Run();
        }
    }
}
