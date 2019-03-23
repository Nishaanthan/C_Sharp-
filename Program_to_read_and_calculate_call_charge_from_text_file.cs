using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Gukajan\Desktop\WriteLines2.txt");

            int charge = 0;

            for (int i= 0; i<lines.Length; i++)
            {
                string[] call = lines[i].Split(',');
                int callTime = Int32.Parse(call[1]);
                string countryCode = call[0].Substring(0, 2);

                if (countryCode == "91"){
                    charge = charge + callTime * 6;
                } else if (countryCode == "81"){
                    charge = charge+ callTime * 19;
                }else if (countryCode == "44"){
                    charge = charge + callTime * 22;
                }else if (countryCode == "33"){
                    charge = charge +  callTime * 11;
                }
            }

            Console.WriteLine("Today's income is Rs.{0}", charge);
            Console.ReadLine();
        }
    }
}
