using System;

namespace Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int min = int.MaxValue;
            for(int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min) min = prices[i];
                else if (prices[i] - min > maxProfit) maxProfit = prices[i] - min;
            }
            return maxProfit;
        }
    }

}
