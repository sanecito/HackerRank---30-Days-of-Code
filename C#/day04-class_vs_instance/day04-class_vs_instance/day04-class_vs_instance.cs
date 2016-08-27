/* Coded by Scott Anecito on 2016/08/24
 * Code provided to add to Scott's code portfoilo
 * Copying this code to use on HackerRank is considered
 * cheating and this code should only be used to help understand
 * potential solutions to problems. By accessing this repo's code 
 * you agree to not copy it in any form for use on HackerRank */

using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public int age;
    public Person(int initialAge)
    {
        // Add some more code to run some checks on initialAge
        if (initialAge >= 0)
        {
            age = initialAge;
        }
        else
        {
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console 
        if (age < 13)
        {
            Console.WriteLine("You are young.");
        }
        if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        if (age >= 18)
        {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses()
    {
        // Increment the age of the person in here
        age += 1;
    }

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}