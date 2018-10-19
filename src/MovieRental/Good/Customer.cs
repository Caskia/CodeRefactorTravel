using System.Collections.Generic;

namespace MovieRental.Good
{
    public class Customer
    {
        public string _name;

        private List<Rental> _rentals;

        public Customer(string name)
        {
            _name = name;

            _rentals = new List<Rental>();
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public void Calculate()
        {
            double totalAmount = 0;
            var totalPoints = 0;

            foreach (var rental in _rentals)
            {
                totalAmount += rental.Movie.GetCharge(rental.DaysRented);
                totalPoints += rental.Movie.GetPoints(rental.DaysRented);
            }
        }
    }
}