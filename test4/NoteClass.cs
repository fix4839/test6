using System;
namespace test4
{
    public class NoteClass
    {
        NotePage[,] masss = new NotePage[12, 31];
        public NotePage this[int i, int j]
        {
            get { return masss[i, j]; }
            set { masss[i, j] = value; }
        }
    }
}
