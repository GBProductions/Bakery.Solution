using System;
using Pastry.Models;
using Bread.Models;
using Order.Models;

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

            int breadResponse =  BreadPrice.BreadIs(bread);
            int pastryResponse = PastryPrice.PastryIs(pastry);
            int overallOrder = OrderPrice.OrderIs(breadResponse, pastryResponse);

            Console.WriteLine("Your order: " + bread + " loaves for $" + breadResponse + ".");
            Console.WriteLine("Your order: " + pastry + " individual pastries for $" + pastryResponse + ".");
            Console.WriteLine("Your total will be $" + overallOrder + ".");

        }
    }
}