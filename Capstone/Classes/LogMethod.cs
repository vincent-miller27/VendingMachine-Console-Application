using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public class LogMethod
    {
        public void WriteToLog(string action, double moneyBefore, double moneyAfter)
        {
            DateTime time = DateTime.Now;
            string date = DateTime.Now.ToShortDateString();
            date = date.Replace('/', '-');
            date = date.Replace(':', '-');

            string directory = Environment.CurrentDirectory;
            string fileOutput = $"{date}-log.txt";
            string fullPath = Path.Combine(directory, fileOutput);
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine("{0, -20} {1,-20} {2, -5} ${3,-8:0.00} ${4:0.00}", time, action, " ", moneyBefore, moneyAfter);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
