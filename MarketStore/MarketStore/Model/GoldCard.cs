using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class GoldCard : Card
    {
        public GoldCard(IPrintOutput printOutput, double turnover) : base(printOutput, turnover)
        {
            this.DiscountRate = 2;
        }
        protected override double CalculateDiscountRate()
        {
            if (Turnover < 0)
                throw new RangeException("Turnover value can not be less then 0. {Gold card}");

            if ((Turnover / 100) + 2 > 10)
                    return 10;
                else
                    return (Turnover / 100) + 2;
        }
    }
}
