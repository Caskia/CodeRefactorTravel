namespace LittleTricks
{
    public class RemoveLongParameters
    {
        public class Bad
        {
            public void SomeMethod(int i, int j, int k, int l, int m, int n)
            {
                //code
            }
        }

        public class Data
        {
            private int i;
            private int j;
            private int k;
            private int l;
            private int m;
            private int n;

            //getter && setter
        }

        public class GoodExample
        {
            public void SomeMethod(Data data)
            {
            }
        }
    }
}