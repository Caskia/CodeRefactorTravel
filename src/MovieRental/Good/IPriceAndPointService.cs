namespace MovieRental.Good
{
    public interface IPriceAndPointService
    {
        double GetCharge(int daysRented);

        int GetPoints(int daysRented);
    }
}