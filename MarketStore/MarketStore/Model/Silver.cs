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
            try
            { 
                if (this.Turnover > 300)
                    return 3.5;
                else
                    return 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
                throw;
            }
}
    }
}
