namespace Pastry.Models
{
    public class PastryPrice
    {
        public static int PastryIs(int pastry)
        {
            var pastryRemainders = (pastry % 3);
            var pastryOrder = (pastry - pastryRemainders);
            var finalOrder = ((pastryOrder / 3) * (5));
            var noDeal = (pastryRemainders * 2);

            return (noDeal + finalOrder);
        }
    }
}

