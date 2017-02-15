using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your total number of hours worked? : ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.Write("what is your hourly pay? : ");
            double pay = Convert.ToDouble(Console.ReadLine());
            double GrossPay = hours * pay;
            double WitholdingTax = GrossPay * 0.12;
            double Net = GrossPay - WitholdingTax;
            if (GrossPay <= 300.00)
            {
                WitholdingTax = GrossPay * 0.10;
            }

            

            Console.WriteLine("Your gross pay is {0}.", GrossPay);
            Console.WriteLine("Your are paying {0} to taxes.",WitholdingTax);
            Console.WriteLine("Your net pay is {0}.", Net);

        }
    }
}
