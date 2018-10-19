using System;

namespace LittleTricks
{
    public class DuplicateFunctions
    {
        public class Bad
        {
            public void SomeMethod1()
            {
                //code
                /* 重复代码块 */
                Console.WriteLine("重复代码");
                //code
            }

            public void SomeMethod2()
            {
                //code
                /* 重复代码块 */
                Console.WriteLine("重复代码");
                //code
            }
        }

        public class Good
        {
            public void SomeMethod1()
            {
                //code
                SomeMethod3();
                //code
            }

            public void SomeMethod2()
            {
                //code
                SomeMethod3();
                //code
            }

            public void SomeMethod3()
            {
                /* 重复代码块 */
                Console.WriteLine("重复代码");
            }
        }
    }
}