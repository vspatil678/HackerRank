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

        int integerVariable;
        double doubleVariable;
        string stringVariable;
        // Declare second integer, double, and String variables.

        // Read and save an integer, double, and String to your variables.
        integerVariable = Convert.ToInt32(Console.ReadLine()); ;
        doubleVariable = Convert.ToDouble(Console.ReadLine()); ;
        stringVariable = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + integerVariable);


        // Print the sum of the double variables on a new line.
        Console.WriteLine((d + doubleVariable).ToString("F1"));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + stringVariable);
        // The 's' variable above should be printed first.

    }
}