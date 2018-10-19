namespace LittleTricks
{
    public class ExtractConstant
    {
        public class Bad
        {
            public void SomeMethod1()
            {
                Send("您的操作已成功！");
            }

            public void SomeMethod2()
            {
                Send("您的操作已成功！");
            }

            public void SomeMethod3()
            {
                Send("您的操作已成功！");
            }

            private void Send(string message)
            {
                //code
            }
        }

        public class Good
        {
            protected const string SuccessMessage = "您的操作已成功！";

            public void SomeMethod1()
            {
                Send(SuccessMessage);
            }

            public void SomeMethod2()
            {
                Send(SuccessMessage);
            }

            public void SomeMethod3()
            {
                Send(SuccessMessage);
            }

            private void Send(string message)
            {
                //code
            }
        }
    }
}