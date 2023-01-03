using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter your Salary");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine("The tax of {0} is : {1}" , input, Tax(number));
        }

        private static double Tax (int num)
        {
            double a =0;
            if (num <= 483000)
            {
                return a;
            }
            else if ( 483000 < num && num < 600001)
            {
                a= num * 10;
            }
            else if (600000 < num && num < 1000001)
            {
                a= num * 15 ;
            }
            else if (1000000 < num && num < 2000001 )
            {
                a= num * 20 ;
            }
            else if ( 2000000 < num && num < 100000000)
            {
                a= num * 30 ;
            }
            else Console.WriteLine("error");
            return a / 100;
        }
    }
}