using System;

namespace inheritanceHackerRank
{

    class Solution
    {

        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double tip = meal_cost * ((double)tip_percent / (double)100);
            Console.WriteLine(tip);


            double tax = meal_cost * ((double)tax_percent / (double)100);
            double totalCost = meal_cost + tip + tax;
            Math.Round(totalCost);
            Console.WriteLine(totalCost);

        }







        class MainClass
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("meal cost: ");
                double meal_cost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("tip percent: ");
                int tip_percent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("tax percent: ");
                int tax_percent = Convert.ToInt32(Console.ReadLine());

                //calc solution
                solve(meal_cost, tip_percent, tax_percent);
            }
        }
    }

}