using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What would you like to know the price of? : ");
            String input = Console.ReadLine().ToUpper();

            if (input == "M")
            {
                Console.WriteLine("The mahogany wood costs $310.");
            }
            else if (input == "P")
            {
                Console.WriteLine("The pine wood costs $100.");
            }
            else if (input == "O")
            {
                Console.WriteLine("The oak wood costs $225.");
            }
            else
                Console.WriteLine("The {ERROR} costs $0.");
        }
    }
}
