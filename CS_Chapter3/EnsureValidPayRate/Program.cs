using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay? : ");
            double pay = Convert.ToDouble(Console.ReadLine());

            if (pay < 5.65 || pay > 49.99)
            {
                Console.Write("Error. Number out of range. Please try again. : ");

                Console.Write("What is your hourly pay? : ");
                pay = Convert.ToDouble(Console.ReadLine());

            }

            if (pay < 5.65 || pay > 49.99)
            {
                Console.WriteLine("ERROR|SYSTEM SHUTTING DOWN|ERROR");
            }
            else
            {
                double week = pay * 40;
                Console.WriteLine("Thank you. Your hourly pay is {0} and your weekly pay is {1}. Have a nice day.", pay, week);
            }

                

        }
    }
}
