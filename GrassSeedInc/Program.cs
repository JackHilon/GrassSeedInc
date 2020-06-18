using System;
using System.Collections.Generic;

namespace GrassSeedInc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grass Seed Inc.
            // https://open.kattis.com/problems/grassseed 

            // I get: Time Limit Exceeded !!!!!
            // ,but it is accepted in the simple way (without exception handling)


            var CostOfOneSqMetreOfLawn = EnterDoubleNum();

            var NumOfLawns = EnterIntNum();

            var totalLawns = TotalArea(NumOfLawns);
            var result = TotalCost(CostOfOneSqMetreOfLawn, totalLawns);

            Console.WriteLine(String.Format("{0:0.000000}", result));
        }
        private static double TotalCost(double unityCost, double area)
        {
            return unityCost * area;
        }

        private static double TotalArea(int a)
        {
            double sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum = sum + EnterLine();
            }
            return sum;
        }
        private static double EnterLine()
        {
            double[] ans = new double[2]{ 0, 0};
            
                string[] arr = Console.ReadLine().Split(' ', 2);
                for (int i = 0; i < arr.Length; i++)
                {
                    ans[i] = double.Parse(arr[i]);
                }
            
            return ans[0] * ans[1]; ;
        }

        private static int EnterIntNum()
        {
            int a =  int.Parse(Console.ReadLine());
            return a;
        }
        private static double EnterDoubleNum()
        {
            double a = double.Parse(Console.ReadLine());
            return a;
        }
    }
}
