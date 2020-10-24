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
        protected override double CalculateDiscountRate()
        {
            throw new NotImplementedException();
        }
    }
}
