using System;
using System.Collections.Generic;
using System.IO;
class Solution26
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        string[] dueDates = s1.Split(' ');
        string[] expectedDates = s2.Split(' ');
        int exptdDay = Convert.ToInt32(expectedDates[0]);
        int dueDay = Convert.ToInt32(dueDates[0]);
        int exptdMonth = Convert.ToInt32(expectedDates[1]);
        int dueMonth = Convert.ToInt32(dueDates[1]);
        int exptdYear = Convert.ToInt32(expectedDates[2]);
        int dueYear = Convert.ToInt32(dueDates[2]);

        if (dueYear > exptdYear)
        {
            Console.WriteLine(10000);
        }
        else if (exptdYear == dueYear && dueMonth > exptdMonth)
        {
            Console.WriteLine(500 * (dueMonth - exptdMonth));
        }
        else if (exptdYear == dueYear && dueMonth == exptdMonth && dueDay > exptdDay)
        {
            Console.WriteLine(15 * (dueDay - exptdDay));
        }
        else
        {
            Console.WriteLine(0);
        }


    }
}

