/* Coded by Scott Anecito on 2016/08/27
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
        int lineCount = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < lineCount; ++i)
        {

            int strPtr = 1;
            string oddStr = "";
            string evenStr = "";
            foreach (char j in Console.ReadLine())
            {
                if (strPtr % 2 == 1)
                {
                    oddStr += j;
                    strPtr++;
                }
                else
                {
                    evenStr += j;
                    strPtr++;
                }
            }

            Console.WriteLine(oddStr + " " + evenStr);
        }
    }
}