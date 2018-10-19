namespace MovieRental.Good
{
    public class Rental
    {
        public int DaysRented { get; set; }

        public Movie Movie { get; set; }

        public void GetCharge()
        {
            switch (Movie.Type)
            {
                case MovieType.Action:
                    break;

                case MovieType.Children:
                    break;

                case MovieType.Love:
                    break;

                default:
                    break;
            }
        }
    }
}