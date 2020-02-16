using System;
using System.Collections.Generic;
using System.IO;
class Solution6
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int inputLines = Convert.ToInt32(Console.ReadLine());
        List<string> inputList = new List<string>();
        for (int i = 0; i < inputLines; i++)
        {
            inputList.Add(Console.ReadLine());
        }
        foreach (var data in inputList)
        {
            string evenChars = "";
            string oddChars = "";
            char[] charData = data.ToCharArray();
            for (int i = 0; i < charData.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenChars = evenChars + charData[i].ToString();
                }
                else
                {
                    oddChars = oddChars + charData[i].ToString();
                }
            }

            Console.WriteLine(evenChars + " " + oddChars);
        }


    }
}

