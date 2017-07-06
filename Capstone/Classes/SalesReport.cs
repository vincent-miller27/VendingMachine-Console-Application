using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public class SalesReport
    {
        public void PrintReport(VendingMachine vend)
        {
            try
            {
                string dateAndTime = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                dateAndTime = dateAndTime.Replace('/', '-');
                dateAndTime = dateAndTime.Replace(':', '-');

                string directory = Environment.CurrentDirectory;
                string fileOutput = $"{dateAndTime}-SalesReport.txt";
                string fullPath = Path.Combine(directory, fileOutput);

                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    foreach (KeyValuePair<string, VendingMachineItem> kvp in vend.VendingDictionary)
                    {
                        sw.WriteLine("{0,-20} {1,-5} {2}", kvp.Value.ItemName, "|", (5 - kvp.Value.Quantity));
                    }

                    sw.WriteLine();
                    sw.WriteLine($"**TOTAL SALES** ${vend.TotalSales: 0.00}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Sales Report Printed!");
            Console.WriteLine();
        }
    }
}
