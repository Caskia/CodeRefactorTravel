using System;
using System.Collections.Generic;
using System.Text;

namespace LittleTricks
{
    public class RemoveTempVariable
    {
        public class Bad
        {
            private int i;

            public int GetVariable()
            {
                return i;
            }

            public int SomeMethod()
            {
                int temp = GetVariable();
                return temp * 100;
            }
        }

        public class Good
        {
            private int i;

            public int GetVariable()
            {
                return i;
            }

            public int SomeMethod()
            {
                return GetVariable() * 100;
            }
        }
    }
}