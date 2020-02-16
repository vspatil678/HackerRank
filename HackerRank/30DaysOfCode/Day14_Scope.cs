using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;
    public int tempDiffNumber;
    // Add your code here
    public Difference(int[] intArray)
    {
        this.elements = intArray;
    }

    public int computeDifference()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                tempDiffNumber = ((elements[i] - elements[j]));
                if (maximumDifference < tempDiffNumber)
                {
                    maximumDifference = tempDiffNumber;
                }

            }
        }
        return maximumDifference;
    }

} // End of Difference Class

class Solution14
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}