using MarketStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Bronze bronzeCard = new Bronze(0);
            bronzeCard.TotalPurchase(150);

            Console.ReadLine();
        }
    }
}
