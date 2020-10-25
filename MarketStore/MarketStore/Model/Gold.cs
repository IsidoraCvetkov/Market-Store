using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Gold : Card
    {
        public Gold(IPrintOutput printOutput, double turnover) : base(printOutput, turnover)
        {
            this.DiscountRate = 2;
        }
        protected override double CalculateDiscountRate()
        {
            try
            {
                if ((this.Turnover / 100) + 2 > 10)
                    return 10;
                else
                    return (this.Turnover / 100) + 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
                throw;
            }
        }
    }
}
