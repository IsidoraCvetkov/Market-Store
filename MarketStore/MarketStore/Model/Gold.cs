using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.Model
{
    class Gold : Card
    {
        private Gold goldCard { get; set; }
        Gold()
        {

        }
        protected override double CalculateDiscountRate()
        {
            throw new NotImplementedException();
        }
    }
}
