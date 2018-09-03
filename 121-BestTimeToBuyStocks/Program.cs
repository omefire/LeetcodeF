using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_BestTimeToBuyStocks
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int MaxProfit(int[] prices)
        {
            if(prices == null || prices.Length == 0)
            {
                return 0;
            }

            int minPrice = int.MaxValue;
            int maxPrice = int.MinValue;
            int profit = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                if(minPrice > prices[i])
                {
                    minPrice = prices[i];
                }
                else if(prices[i] < maxPrice)
                {
                    maxPrice = prices[i];
                }

                if(profit < (maxPrice - minPrice))
                {
                    profit = (maxPrice - minPrice);
                }
            }

            return profit;
        }
    }
}
