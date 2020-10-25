using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public interface IPrintOutput
    {
        void PrintResult(double purchaseValue, double discountRate, double discount, double total);
    }
}
