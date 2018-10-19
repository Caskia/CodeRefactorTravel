namespace MovieRental.Good
{
    public class ChildrenMoviePriceAndPointSerivce : IPriceAndPointService
    {
        public double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public int GetPoints(int daysRented)
        {
            return 1;
        }
    }
}