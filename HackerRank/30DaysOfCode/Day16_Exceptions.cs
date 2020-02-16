using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution16
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        try
        {
            int num = Convert.ToInt32(S);
            Console.WriteLine(num);
        }
        catch (Exception e)
        {
            Console.WriteLine("Bad String");
        }
    }
}

