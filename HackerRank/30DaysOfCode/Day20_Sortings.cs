using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution20
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        // Write Your Code Here

        int numberOfSwaps = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                var temp = a[i];
                if (a[i] > a[j])
                {
                    temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                    numberOfSwaps++;
                }
            }


        }

        int first = 0;
        int last = 0;
        for (int k = 0; k < a.Length; k++)
        {
            first = a[0];
            last = a[a.Length - 1];
        }

        Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");

        Console.WriteLine("First Element: " + first);
        Console.WriteLine("Last Element: " + last);


    }
}

