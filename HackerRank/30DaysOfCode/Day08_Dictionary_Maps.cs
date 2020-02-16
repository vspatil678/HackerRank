using System;
using System.Collections.Generic;
using System.IO;

class Solution8
{
    static void Main(String[] args)
    {
        Dictionary<String, String> PhoneBook = new Dictionary<String, String>();
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine().Split(' ');
            PhoneBook.Add(s[0], s[1]);
        }

        String name;

        while ((name = Console.ReadLine()) != null)
        {
            try
            {
                Console.WriteLine($"{name}={PhoneBook[name]}");
            }
            catch
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
