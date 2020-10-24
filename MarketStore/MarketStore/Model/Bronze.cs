using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Bronze : Card
    {
        public Bronze() { }
        public Bronze(double turnover)
        {
            this.Turnover = turnover;
        }
        protected override double CalculateDiscountRate()
        {
            if (this.Turnover < 100)
                return 0;
            else if (this.Turnover > 300)
                return 2.5;
            else
                return 1;
        }
    }
}
