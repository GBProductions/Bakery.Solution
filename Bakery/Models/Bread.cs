namespace Bakery.Models
{
    public class BreadPrice
    {
        public static int BreadIs(int bread)
        {
            if (bread >= 3) {
                var breadRemainders = (bread % 3);
                var noDeal = (breadRemainders * 5);
                var breadOrder = (bread - breadRemainders);
                var finalOrder = ((breadOrder * (2/3)) * 5);
                return (noDeal + finalOrder);       
            } else {
                return (bread * 5);
            }
        }
    }
}