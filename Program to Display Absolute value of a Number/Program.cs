using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace example///In this C# program, we are reading a number using ‘num’ variable. If condition statement is used to check the value of ‘num’ variable is less than 0. Here “Absolute value” means to remove any negative sign in front of a number, and to think of all numbers as positive. If the condition is true then execute the statement. Multiply the negative one value with num variable. Print the absolute value of a number.//
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                num = num * -1;
            }

            Console.WriteLine("Absolute value : " + num);
            Console.ReadLine();
        }
    }
}
///Output:Enter a number:-50
///Absolute value : 50