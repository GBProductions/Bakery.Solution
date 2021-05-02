namespace Bakery.Models
{
    public class Pastry
    {
        //Public properties
        public int PastryPrice { get; set; }
        public int PastryNumber { get; set; }

        //Constructor
        public Pastry(int pastryPrice, int pastryNumber)
        {
            PastryPrice = pastryPrice;
            PastryNumber = pastryNumber;
        }

        public static int CalculatePastry(int pastryPrice, int pastryNumber)
        {
            if (pastryNumber <= 2) {
                return (pastryNumber * pastryPrice);
            } else {
                var pastryRemainders = (pastryNumber % 3);
                var pastryOrder = (pastryNumber - pastryRemainders);
                var finalOrder = ((pastryOrder / 3) * (5));
                var noDeal = (pastryRemainders * pastryPrice);

                return (noDeal + finalOrder);
            }
        }
    }
}

