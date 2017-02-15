using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade point average? : ");
            double grade = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your admission test score? : ");
            double test = Convert.ToDouble(Console.ReadLine());

            if (grade >= 3.0 && test >= 60)
            {
                Console.WriteLine("CONGRATULATIONS! You have been accepted!");
            }
            else if (grade < 3.0 && test >= 80)
            {
                Console.WriteLine("CONGRATULATIONS! You have been accepted!");
            }
            else
            {
                Console.WriteLine("Sorry. You have been rejected.");
            }

            }
        }
    }
