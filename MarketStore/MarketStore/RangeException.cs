using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class RangeException : Exception
    {
        public RangeException(string message) : base(message)
        {
        }
    }
}
