using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much is your hourly pay? : ");
            double payRate = Convert.ToDouble(Console.ReadLine());
            if (payRate < 5.65)
                Console.WriteLine("ERROR. NUMBER TOO LOW");
            if (payRate > 49.99)
                Console.WriteLine("ERROR. NUMBER TOO HIGH");
        }
    }
}
