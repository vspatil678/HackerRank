namespace HackerRank._30DaysOfCode
{
    using System;

    /// <summary>
    /// Defines the <see cref="Day0_HelloWorld" />
    /// </summary>
    internal class Day0_HelloWorld
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="String[]"/></param>
        internal static void Main(string[] args)
        {
            // Declare a variable named 'inputString' to hold our input.
            string inputString;
            string input_string = Console.ReadLine();
            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine();
            //input_string = Console.ReadLine();
            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");

            // TODO: Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(input_string);
        }
    }
}
