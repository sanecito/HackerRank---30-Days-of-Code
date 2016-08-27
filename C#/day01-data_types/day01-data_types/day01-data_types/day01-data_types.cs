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
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int j;
        double e;
        string t;

        // Read and save an integer, double, and String to your variables.
        j = Int32.Parse(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());
        t = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + j);

        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:N1}", d + e);

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + t);
    }
}