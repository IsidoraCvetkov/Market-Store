using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Silver : Card
    {
        private Silver silverCard { get; set; }
        Silver()
        {

        }
        public override double CalculateDiscountRate()
        {
            throw new NotImplementedException();
        }
        public override double TotalPurchase(double purchaseValue)
        {
            throw new NotImplementedException();
        }
        public override double CalculateDiscount(double purchaseValue)
        {
            throw new NotImplementedException();
        }
    }
}
