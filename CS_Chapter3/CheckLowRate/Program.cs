using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much is your hourly pay rate? : ");
            double payRate = Convert.ToDouble(Console.ReadLine());
            if (payRate < 5.65) 
                Console.WriteLine("ERROR");
        }
    }
}
