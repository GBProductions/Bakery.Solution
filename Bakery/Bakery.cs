using System;
// using Bakery.PastryPrices;
// using Bakery.BreadPrices;
using System.Collections.Generic;

namespace Bakery
{
    public class BakeryProgram
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread is $5. OR buy 2, get 1 free.");
            Console.WriteLine("Pastry is $2. OR buy 3 for $5.");

            Console.WriteLine("How many loaves of Bread do you want? Enter a number please.");
            string stringBread = Console.ReadLine();
            int bread = int.Parse(stringBread);

            Console.WriteLine("How many pastries do you want? Enter a number please.");
            string stringPastry = Console.ReadLine();
            int pastry = int.Parse(stringPastry);

            Console.WriteLine("You want " + bread + " loaves and " + pastry + " individual pastries.");
        }
    }
}