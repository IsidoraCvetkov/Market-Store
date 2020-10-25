using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Bronze : Card
    {
        public Bronze(IPrintOutput printOutput, double turnover) : base(printOutput, turnover)
        {
        }
        protected override double CalculateDiscountRate()
        {
            if(Turnover < 0)
                throw new RangeException("Turnover value can not be less then 0. {Bronze card}"); 

            if (Turnover < 100)
                return 0;
            else if (Turnover > 300)
                return 2.5;
            else
                return 1;
        }
    }
}
