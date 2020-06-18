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
            string[] arr = new string[] { "", "" };
            double[] ans = new double[2]{ 0, 0};
            double area = 0;
            try
            {
                arr = Console.ReadLine().Split(' ', 2);
                for (int i = 0; i < arr.Length; i++)
                {
                    ans[i] = double.Parse(arr[i]);
                }
                if (ans[0] < 0 || ans[0] > 100 || ans[1] < 0 || ans[1] > 100)
                    throw new ArgumentException();
                area = ans[0] * ans[1];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString() + " || " + ex.Message);
                return EnterLine();
            }
            return area;
        }

        private static int EnterIntNum()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a <= 0 || a > 100)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString()+" || "+ex.Message);
                return EnterIntNum();
            }
            return a;
        }
        private static double EnterDoubleNum()
        {
            double a = 0;
            try
            {
                a = double.Parse(Console.ReadLine());
                if (a <= 0 || a > 100)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString() + " || " + ex.Message);
                return EnterDoubleNum();
            }
            return a;
        }
    }
}
