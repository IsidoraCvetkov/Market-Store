using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class PrintOutput : IPrintOutput
    {
        public void PrintResult(double purchaseValue, double discountRate, double discount, double total)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Purchase value: " + purchaseValue + "$" +
                "\nDiscount rate: " + discountRate + "%" +
                "\nDiscount: " + discount + "$" +
                "\nTotal: " + total + "$");
            Console.WriteLine("=================================");
        }
    }
}
