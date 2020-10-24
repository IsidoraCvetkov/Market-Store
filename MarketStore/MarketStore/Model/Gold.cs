using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Gold : Card
    {
        public Gold()
        {
            this.DiscountRate = 2;
        }
        public Gold(double turnover)
        {
            this.Turnover = turnover;
            this.DiscountRate = 2;
        }
        protected override double CalculateDiscountRate()
        {
            if ((this.Turnover / 100) + 2 > 10)
                return 10;
            else
                return (this.Turnover / 100) + 2;
        }
    }
}
