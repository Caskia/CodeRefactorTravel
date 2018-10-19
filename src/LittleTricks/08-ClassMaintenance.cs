namespace LittleTricks
{
    public class ClassMaintenance
    {
        public class Bad
        {
            public int SomeMethod(Data data)
            {
                int i = data.GetI();
                int j = data.GetJ();
                int k = data.GetK();
                return i * j * k;
            }

            public class Data
            {
                private int i;
                private int j;
                private int k;

                public Data(int i, int j, int k)
                {
                    this.i = i;
                    this.j = j;
                    this.k = k;
                }

                public int GetI()
                {
                    return i;
                }

                public int GetJ()
                {
                    return j;
                }

                public int GetK()
                {
                    return k;
                }
            }
        }

        public class Good
        {
            public int SomeMethod(Data data)
            {
                return data.GetResult();
            }

            public class Data
            {
                private int i;
                private int j;
                private int k;

                public Data(int i, int j, int k)
                {
                    this.i = i;
                    this.j = j;
                    this.k = k;
                }

                public int GetI()
                {
                    return i;
                }

                public int GetJ()
                {
                    return j;
                }

                public int GetK()
                {
                    return k;
                }

                public int GetResult()
                {
                    return i * j * k;
                }
            }
        }
    }
}