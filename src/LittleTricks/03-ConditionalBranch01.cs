namespace LittleTricks
{
    public class ConditionalBranch01
    {
        public class Bad
        {
            public void SomeMethod(object a, object b)
            {
                if (a != null)
                {
                    if (b != null)
                    {
                        //code[1]
                    }
                    else
                    {
                        //code[3]
                    }
                }
                else
                {
                    //code[2]
                }
            }
        }

        public class Good
        {
            public void SomeMethod(object a, object b)
            {
                if (a == null)
                {
                    //code[2]
                    return;
                }
                if (b == null)
                {
                    //code[3]
                    return;
                }
                //code[1]
            }
        }
    }
}