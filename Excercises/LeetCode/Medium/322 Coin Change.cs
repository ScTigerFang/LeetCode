using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/coin-change/
    /// </summary>
    public class Coin_Change_322
    {
        public static int CoinChange(int[] coins, int amount)
        {
            int minCoinsRequired = 0;
            int amountLeft = amount;
            //This was my first attempt - failed a certain test but passed others, need to improve.
            //something to look into to understand https://leetcode.com/problems/coin-change/discuss/77466/C-implementation
            if (amount == 0)
                return 0;
            if (coins.Min() > amount)
            {
                return -1;
            }
            foreach (var coin in coins)
            {
                Console.WriteLine("Trying to solve it with first solution");
                var coins_copy = coins;
                while (coins_copy.Length != 0 && amountLeft != 0)
                {
                    minCoinsRequired += amountLeft / coins_copy.Max();
                    Console.WriteLine(amountLeft + "%" + coins_copy.Max().ToString() + " = " + amountLeft % coins_copy.Max());
                    amountLeft = amountLeft % coins_copy.Max();
                    Console.ReadLine();

                    coins_copy = coins_copy.Where(coin => coin != coins_copy.Max()).ToArray();
                };
                if (amountLeft == 0)
                {
                    return amountLeft == 0 ? minCoinsRequired : -1;
                }
                Console.WriteLine("Trying again but removing the highest valued coin");
                coins = coins.Where(coin => coin != coins.Max()).ToArray();
                Console.ReadLine();
                amountLeft = amount;
            }

            return amountLeft == 0 ? minCoinsRequired : -1;
        }
    }
}
