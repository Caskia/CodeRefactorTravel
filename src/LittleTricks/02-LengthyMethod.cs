namespace LittleTricks
{
    public class LengthyMethod
    {
        public class Bad
        {
            public void SomeMethod()
            {
                //function[1]
                //function[2]
                //function[3]
            }
        }

        public class Good
        {
            public void SomeMethod()
            {
                SomeMethod1();
                SomeMethod2();
                SomeMethod3();
            }

            public void SomeMethod1()
            {
                //function[1]
            }

            public void SomeMethod2()
            {
                //function[2]
            }

            public void SomeMethod3()
            {
                //function[3]
            }
        }
    }
}