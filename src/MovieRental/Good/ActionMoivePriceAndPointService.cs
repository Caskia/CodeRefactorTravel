namespace MovieRental.Good
{
    public class ActionMoivePriceAndPointService : IPriceAndPointService
    {
        public double GetCharge(int daysRented)
        {
            double amount = 2;

            if (daysRented > 2)
            {
                amount += (daysRented - 2) * 1.5;
            }

            return amount;
        }

        public int GetPoints(int daysRented)
        {
            return 1;
        }
    }
}