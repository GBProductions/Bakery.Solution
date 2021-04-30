namespace Bakery.Models
{
    public class PastryPrice
    {
        public static int PastryIs(int pastry)
        {
            if (pastry <= 2) {
                return (pastry * 2);
            } else {
                var pastryRemainders = (pastry % 3);
                var pastryOrder = (pastry - pastryRemainders);
                var finalOrder = ((pastryOrder / 3) * (5));
                var noDeal = (pastryRemainders * 2);

                return (noDeal + finalOrder);
            }
        }
    }
}

