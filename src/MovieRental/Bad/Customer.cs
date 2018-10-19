using System.Collections.Generic;

namespace MovieRental.Bad
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
                switch (rental.Movie.Type)
                {
                    case MovieType.Action:
                        totalAmount += 2;
                        if (rental.DaysRented > 2)
                        {
                            totalAmount += (rental.DaysRented - 2) * 1.5;
                        }

                        totalPoints += 1;
                        break;

                    case MovieType.Children:
                        totalAmount += rental.DaysRented * 3;

                        totalPoints++;
                        break;

                    case MovieType.Love:
                        totalAmount += 1.5;
                        if (rental.DaysRented > 3)
                        {
                            totalAmount += (rental.DaysRented - 3) * 1.5;
                        }

                        totalPoints += 2;
                        if (rental.DaysRented > 1)
                        {
                            totalPoints += (rental.DaysRented - 1) * 1;
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}