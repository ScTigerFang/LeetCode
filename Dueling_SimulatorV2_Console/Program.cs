using System;
using System.Collections.Generic;
using System.Globalization;

namespace Dueling_SimulatorV2_Console
{
    class Program
    {
        public static decimal startingCashStack { get; set; }
        public static decimal goalCashStack { get; set; }
        public static decimal initialBet { get; set; }
        public static decimal numberOfRuns { get; set; }


        static void Main(string[] args)
        {
            startingCashStack = 1000000;
            goalCashStack = 2000000;
            initialBet = 1;
            numberOfRuns = 10000000;
            bool done = false;

            while (!done)
            {
                DisplayMenu();
                //GetInputs();
                Stakes();
                Console.WriteLine("Type Y for another");
                done = Console.ReadLine() != "Y";
            }
        }

        private static void Stakes()
        {
            Dictionary<int, StakeResult> stakeResults = new Dictionary<int, StakeResult>();
            decimal currentCashStack = startingCashStack;
            int duelNumber = 0;
            decimal amountStaking = initialBet;

            int totalWins = 0;
            int currentWinStreak = 0;
            int longestWinStreak = 0;

            int totalLoses = 0;
            int currentLoseStreak = 0;
            int longestLoseStreak = 0;

            while ((currentCashStack > 0 && currentCashStack < goalCashStack)
                && duelNumber < numberOfRuns)
            {
                duelNumber++;
                var duelResults = duel();
                if (duelResults)
                {
                    totalWins++;
                    longestLoseStreak = longestLoseStreak > currentLoseStreak ? longestLoseStreak : currentLoseStreak;
                    currentLoseStreak = 0;
                    currentWinStreak++;
                    longestWinStreak = longestWinStreak > currentWinStreak ? longestWinStreak : currentWinStreak;

                    currentCashStack += amountStaking;
                    StakeResult stakeResult = new StakeResult
                    {
                        duelNumber = duelNumber,
                        isWin = duelResults,
                        resultMessage = "You have won the duel!",
                        stakeAmount = amountStaking,
                        currentCashStack = currentCashStack,
                        currentProgress = currentCashStack - startingCashStack
                    };
                    stakeResults.Add(stakeResult.duelNumber, stakeResult);
                    amountStaking = initialBet;
                }
                else
                {
                    totalLoses++;
                    longestWinStreak = longestWinStreak > currentWinStreak ? longestWinStreak : currentWinStreak;
                    currentWinStreak = 0;
                    currentLoseStreak++;
                    longestLoseStreak = longestLoseStreak > currentLoseStreak ? longestLoseStreak : currentLoseStreak;

                    //Martingale System
                    //Double the bet after every loss
                    //and return to original bet after each win.
                    //If bet amount exceed the table limit, the table limit will be used as bet amount.
                    //If the next bet amount exceed your capital, the current one will be used if you have enough money.
                    //Otherwise the inital bet amount will be used.
                    currentCashStack -= amountStaking;
                    StakeResult stakeResult = new StakeResult
                    {
                        duelNumber = duelNumber,
                        isWin = duelResults,
                        resultMessage = "You lost noob!",
                        stakeAmount = amountStaking,
                        currentCashStack = currentCashStack,
                        currentProgress = currentCashStack - startingCashStack
                    };
                    stakeResults.Add(stakeResult.duelNumber, stakeResult);
                    if (amountStaking * 2 > currentCashStack)
                    {
                        amountStaking = currentCashStack;
                    }
                    else
                    {
                        amountStaking = amountStaking * 2;
                    }
                }
            }

            ReportOfResultsOfStake(stakeResults,
                totalWins,
                longestWinStreak,
                totalLoses,
                longestLoseStreak,
                currentCashStack,
                duelNumber);
        }

        private static void ReportOfResultsOfStake(
            Dictionary<int, StakeResult> stakeResults,
            int totalWins,
            int longestWinStreak,
            int totalLoses,
            int longestLoseStreak,
            decimal currentCashStack,
            int duelNumber)
        {
            DisplayMenu();
            Console.WriteLine($"\n ---- Staking Results ---- \n");
            if (currentCashStack >= goalCashStack)
            {
                Console.WriteLine("Current Cash Stack : {0}" +
                    "\n You reach your goal in {1} duels ^_^", currentCashStack,duelNumber);
            }
            else
            {
                Console.WriteLine("Current Cash Stack : {0}" +
                    "\n You lost it all in {1} duels :(", currentCashStack, duelNumber);
            }
            Console.WriteLine("\n Wins : {0} , Longest Win Streak {1}", totalWins, longestWinStreak);
            Console.WriteLine("\n Loses : {0} , Longest lose Streak {1}", totalLoses, longestLoseStreak);
            /*
            Console.WriteLine($"\n ---- Staking Report ---- \n");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                    "duelNumber",
                    "resultMessage",
                    "stakeAmount",
                    "currentCashStack",
                    "currentProgress");
            foreach (var stake in stakeResults)
            {
                Console.WriteLine($"\n {stake.Value.duelNumber}, {stake.Value.resultMessage}, {stake.Value.stakeAmount}, {stake.Value.currentCashStack}, {stake.Value.currentProgress}");
            }
            */
        }

        private static bool duel()
        {
            var random = new Random();
            var duelResult = random.Next(2) == 1; // 0 = false/lose, 1 = true/win;
            return duelResult;
        }

        static public void DisplayMenu()
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            Console.Clear();

            Console.WriteLine("--------- Dueling Simulator -------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cash Stack: {startingCashStack}, Goal: {goalCashStack}, Bet Amount: {initialBet}, Max Runs: {numberOfRuns}");
        }

        public static void GetInputs()
        {
            Console.WriteLine("Starting GP: ");
            startingCashStack = int.Parse(Console.ReadLine());
            DisplayMenu();
            Console.WriteLine("Goal Amount: ");
            goalCashStack = int.Parse(Console.ReadLine());
            DisplayMenu();
            Console.WriteLine("Initial Betting Amount: ");
            initialBet = int.Parse(Console.ReadLine());
            DisplayMenu();
            Console.WriteLine("Number of Runs: ");
            try
            {
                numberOfRuns = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                numberOfRuns = 0;
            }
            DisplayMenu();
        }
    }
}
