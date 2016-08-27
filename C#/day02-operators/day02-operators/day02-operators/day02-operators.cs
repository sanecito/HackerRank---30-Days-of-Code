/* Coded by Scott Anecito on 2016/08/22
 * Code provided to add to Scott's code portfoilo
 * Copying this code to use on HackerRank is considered
 * cheating and this code should only be used to help understand
 * potential solutions to problems. By accessing this repo's code 
 * you agree to not copy it in any form for use on HackerRank */


using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        decimal mealCost = decimal.Parse(Console.ReadLine());
        decimal tipPercent = Int32.Parse(Console.ReadLine());
        decimal taxPercent = Int32.Parse(Console.ReadLine());

        decimal tipTotal = (decimal)(mealCost * (tipPercent / 100));
        decimal taxTotal = (decimal)(mealCost * (taxPercent / 100));

        decimal totalCost = mealCost + tipTotal + taxTotal;

        Console.WriteLine("The total meal cost is " + Decimal.Round(totalCost) + " dollars.");
    }
}