namespace MovieRental.Bad
{
    public enum MovieType
    {
        //2天之内含2天，每部收费2元，超过2天的部分每天收费1.5元
        //积分1
        Action,

        //每天每部3元
        //积分1
        Children,

        //3天之内含3天，每部收费1.5元，超过3天的部分每天收费1.5元
        //积分2, 超过1天的部分每天多1
        Love
    }

    public class Movie
    {
        public string Description { get; set; }

        public string Title { get; set; }

        public MovieType Type { get; set; }
    }
}