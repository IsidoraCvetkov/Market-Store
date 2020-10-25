using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Silver : Card
    {
        public Silver(IPrintOutput printOutput, double turnover) : base(printOutput, turnover)
        {
        }
        protected override double CalculateDiscountRate()
        {
            if (Turnover < 0)
                throw new RangeException("Turnover value can not be less then 0. {Silver card}");

            if (Turnover > 300)
                    return 3.5;
                else
                    return 2;
        }
    }
}
