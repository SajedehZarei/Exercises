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
            int a = 0; // مثلث نباشد
            Console.WriteLine("Please Enter 3 number: \n");
            int x = Convert.ToInt32( Console.ReadLine());
            int y = Convert.ToInt32( Console.ReadLine());
            int z = Convert.ToInt32( Console.ReadLine());
            if((x+y > z && (x+z > y)&& (y+z > x)))
            {
                if((x == y) && (a == z)) //مثلث متوازی الاضلاع
                {a = 3;}
                else if((x == y) || (x == z) || (y == z)) //مثلث متساوی الساقین
                {a= 2;}
                else if((Math.Pow(x,2)+Math.Pow(y,2) == Math.Pow(z,2))||(Math.Pow(z,2)+Math.Pow(y,2) == Math.Pow(x,2))||(Math.Pow(x,2)+Math.Pow(z,2) == Math.Pow(y,2)))//مثلث قايم الزاویه
                {a= 1;} 
            }  
            Console.WriteLine("The result is:{0}",a);
        }

   
    }
}