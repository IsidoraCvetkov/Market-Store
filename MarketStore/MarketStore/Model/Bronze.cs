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
            try
            {
                if (this.Turnover < 100)
                    return 0;
                else if (this.Turnover > 300)
                    return 2.5;
                else
                    return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
                throw;
            }
        }
    }
}
