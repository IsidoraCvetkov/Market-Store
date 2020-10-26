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

            try
            {
                BronzeCard bronzeCard = new BronzeCard(printOutput, 0);
                bronzeCard.TotalPurchase(150);
            }
            catch(RangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                SilverCard silverCard = new SilverCard(printOutput, 600);
                silverCard.TotalPurchase(850);
            }
            catch (RangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                GoldCard goldCard = new GoldCard(printOutput, 1500);
                goldCard.TotalPurchase(1300);
            }
            catch (RangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
