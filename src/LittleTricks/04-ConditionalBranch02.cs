using System;
using System.Collections.Generic;
using System.Text;

namespace LittleTricks
{
    public class ConditionalBranch02
    {
        public class Bad
        {
            public void SomeMethod(object a, object b)
            {
                if (a != null)
                {
                    if (b != null)
                    {
                        //code
                    }
                }
            }
        }

        public class Good
        {
            public void SomeMethod(object a, object b)
            {
                if (a != null && b != null)
                {
                    //code
                }
            }
        }
    }
}