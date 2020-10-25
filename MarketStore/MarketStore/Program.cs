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
            IPrintOutput printOutput = new PrintOutput();

            Bronze bronzeCard = new Bronze(printOutput, 0);
            bronzeCard.TotalPurchase(150);

            Silver silverCard = new Silver(printOutput, 600);
            silverCard.TotalPurchase(850);

            Gold goldCard = new Gold(printOutput, 600);
            goldCard.TotalPurchase(1300);

            Console.ReadLine();
        }
    }
}
