﻿/* Coded by Scott Anecito on 2016/08/24
 * Code provided to add to Scott's code portfoilo
 * Copying this code to use on HackerRank is considered
 * cheating and this code should only be used to help understand
 * potential solutions to problems. By accessing this repo's code 
 * you agree to not copy it in any form for use on HackerRank */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        if (N % 2 == 1)
        {
            Console.WriteLine("Weird");
        }
        else if(2 <= N && N <= 5) {
            Console.WriteLine("Not Weird");
        }
        else if(6 <= N && N <= 20) {
            Console.WriteLine("Weird");
        }
        else if(N >= 20) {
            Console.WriteLine("Not Weird");
        }
    }
}
