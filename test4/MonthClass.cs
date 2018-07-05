using System;
namespace test4
{
    public class MonthClass
    {
        DayPage[,] masss = new DayPage[12,31];
        public DayPage this[int i, int j]
        {
            get { return masss[i, j]; }
            set { masss[i, j] = value; }
        }
    }
}
