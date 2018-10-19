using System;
using System.Collections.Generic;
using System.Text;

namespace LittleTricks
{
    public class ClassInherit
    {
        public class Bad
        {
            public class Student
            {
                public int Age { get; set; }

                public string Name { get; set; }
                public int Rank { get; set; }

                public void Eat()
                {
                }

                public void Learn()
                {
                }
            }

            public class Teacher
            {
                public int Age { get; set; }

                public int Level { get; set; }

                public string Name { get; set; }

                public void Eat()
                {
                }

                public void Teach()
                {
                }
            }
        }

        public class Good
        {
            public abstract class Person
            {
                public virtual int Age { get; set; }

                public virtual string Name { get; set; }

                public virtual void Eat()
                {
                }
            }

            public class Student : Person
            {
                public int Rank { get; set; }

                public override void Eat()
                {
                    base.Eat();
                }

                public void Learn()
                {
                }
            }

            public class Teacher : Person
            {
                public int Level { get; set; }

                public override void Eat()
                {
                    base.Eat();
                }

                public void Teach()
                {
                }
            }
        }
    }
}