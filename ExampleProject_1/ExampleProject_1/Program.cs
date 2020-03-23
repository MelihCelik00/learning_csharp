using System;
using System.Collections.Generic;
using System.IO;
namespace ExampleProject_1
{
    class Solution
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int sum;
            double dabdab;
            string str;

            sum = Convert.ToInt32(Console.ReadLine());
            string strToDouble = Console.ReadLine();
            str = Console.ReadLine();


            dabdab = double.Parse(strToDouble);

            Console.WriteLine(i + sum);
            Console.WriteLine("{0:F1}", d + dabdab);
            Console.WriteLine(s + str);

            // Declare second integer, double, and String variables.

            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.

        }
    }
}