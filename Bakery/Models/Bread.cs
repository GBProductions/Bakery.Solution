namespace Bakery.Models
{
    public class Bread
    {
        //Public properties
        public int BreadPrice { get; set; }
        public int BreadNumber { get; set; }

        //Constructor
        public Bread(int breadPrice, int breadNumber)
        {
            BreadPrice = breadPrice;
            BreadNumber = breadNumber;
        }

        public static int CalculateBread(int breadPrice, int breadNumber)
        {
            if (breadNumber >= 2) {
                var breadRemainder = (breadNumber % 3);
                var noDeal = (breadPrice * breadRemainder);
                var breadOrder = (breadNumber - breadRemainder);
                var cost = (((breadOrder / 3) * 2) * breadPrice);
            return (cost + noDeal);
            } else {
                return (breadNumber * breadPrice);
            }
            
        }
    }
}