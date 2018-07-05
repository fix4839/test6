using System;
namespace test4
{
    public class DaysClass
    {
        DayPage[] mass = new DayPage[31];
        public DayPage this[int i]
        {
            get { return mass[i]; }
            set { mass[i] = value; }
        }
    }
}
