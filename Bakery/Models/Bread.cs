namespace Bread.Models
{
    public class BreadPrice
    {
        public static int BreadIs(int bread)
        {
            if (bread <= 2) {
                return (bread * 5);
            } else {
                var breadRemainders = (bread % 3);
                var noDeal = (breadRemainders * 5);

                var breadOrder = (bread - breadRemainders);
                var preDiscountOrder = (bread * 5);
                var finalOrder = (preDiscountOrder - ((breadOrder / 3) * 5));
                

                return (noDeal + finalOrder);
            }
        }
    }
}