using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    abstract class Card
    {
        protected string Owner { get; set; }
        protected double Turnover { get; set; }
        protected double DiscountRate { get; set; }
        protected abstract double CalculateDiscountRate();
        protected IPrintOutput PrintOutput;
        public Card(IPrintOutput printOutput, double turnover)
        {
            this.Turnover = turnover;
            this.PrintOutput = printOutput;
        }
        protected double CalculateDiscount(double purchaseValue)
        {
            return purchaseValue * CalculateDiscountRate() / 100;
        }
        public double TotalPurchase(double purchaseValue)
        {
            PrintOutput.PrintResult(purchaseValue, CalculateDiscountRate(), CalculateDiscount(purchaseValue), purchaseValue - CalculateDiscount(purchaseValue));
            return purchaseValue - CalculateDiscount(purchaseValue);
        }

        //public void PrintResult(double purchaseValue, double discountRate, double discount, double total)
        //{
        //    Console.WriteLine("=================================");
        //    Console.WriteLine("Purchase value: " + purchaseValue + "$" + 
        //        "\nDiscount rate: "+ discountRate + "%" +
        //        "\nDiscount: " + discount + "$" +
        //        "\nTotal: " + total + "$");
        //    Console.WriteLine("=================================");
        //}
    }
}
