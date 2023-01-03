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
            Console.WriteLine("Please Enter your number: \n");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine(WriteX(number));
        }

        private static string WriteX (int num)
        {
            string a ="";
           for (int i = 0; i < num; i++)
           {
            for ( int j =0 ; j< 10 ; j++)
            {
                a =a + "x";
            }
            //Console.WriteLine("{0}",a);
            a=a+"\n";
           }
           return a;
        }
    }
}