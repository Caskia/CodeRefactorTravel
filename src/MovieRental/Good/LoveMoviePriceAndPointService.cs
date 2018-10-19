using System;

namespace MovieRental.Good
{
    public class LoveMoviePriceAndPointService : IPriceAndPointService
    {
        public double GetCharge(int daysRented)
        {
            double amount = 1.5;
            if (daysRented > 3)
            {
                amount += (daysRented - 3) * 1.5;
            }

            return amount;
        }

        public int GetPoints(int daysRented)
        {
            var point = 2;
            if (daysRented > 1)
            {
                point += (daysRented - 1) * 1;
            }

            return point;
        }
    }
}