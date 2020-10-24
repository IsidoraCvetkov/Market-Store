using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Silver : Card
    {
        public Silver() { }
        public Silver(double turnover)
        {
            this.Turnover = turnover;
        }
        protected override double CalculateDiscountRate()
        {
            if (this.Turnover > 300)
                return 3.5;
            else
                return 2;
        }
    }
}
