using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04.Delegate
{

    internal class CompareFunction
    {
        public static bool CompareGrt(int X, int Y)
        {
            return Y > X;
        }
        public static bool CompareLess(int X, int Y)
        {
            return X > Y;
        }

        public static bool stringAsc(string A, string B)
        {
            return A?.Length > B?.Length;
        }
        public static bool stringDsc(string A, string B)
        {
            return A?.Length < B?.Length;
        }
    }
}
