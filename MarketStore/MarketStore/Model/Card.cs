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
        public abstract double CalculateDiscountRate();
        public abstract double CalculateDiscount(double purchaseValue);
        public abstract double TotalPurchase(double purchaseValue);
    }
}
