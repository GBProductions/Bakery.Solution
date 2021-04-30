namespace Bakery.Models
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
                var finalOrder = ((breadOrder * (2/3)) * 5);
                
                return (noDeal + finalOrder);
            }
        }
    }
}