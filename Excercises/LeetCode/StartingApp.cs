using System;
using LeetCode.Medium;

namespace LeetCode
{
    class LeetCode
    {
        public static void Main(string[] args)
        {
            int choose;
            Console.WriteLine("Choose Level of diffuculity Level");
            Console.WriteLine("1 = Easy, 2 = Medium, 3 = Hard");
            int.TryParse(Console.ReadLine(), out choose);
            

            switch (choose)
            {
                case 1:
                    Easy();
                    break;
                case 2:
                    Medium();
                    break;
                default:
                    var a  = 0;
                    break;
            }
        }

        public static void Easy() { 
        }

        public static void Medium() {

            int choose;
            int[] coins = { 186, 419, 83, 408 };
            int amount = 6249;
            Console.WriteLine("Which Problem");
            choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Answer" + Coin_Change_322.CoinChange( coins, amount).ToString());
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
