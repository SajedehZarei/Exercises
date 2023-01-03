using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        // 1/1! + 2/2! + ... + n/n!
        public static void Main()
        {
            double sum=0;
            Console.WriteLine("Please Enter your number: \n");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            for(int j = number; j>=1; j--)
            {
                sum = sum+ Fact(j);
            }
            Console.WriteLine(sum);
        }

        private static double Fact (int num)
        {
            double fact;
            fact = num;
            for (int i = num-1 ; i >= 1; i--)
            {
                fact = fact * i;
            }
           return num/fact;
        }
    }
}