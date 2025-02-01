using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04.Delegate
{
    internal class Conditions
    {

        public static bool OddNumber(int X)
        {
            return X % 2 == 1;
        }

        public static bool EvenNumber(int X)
        {
            return X % 2 == 0;
        }

        public static bool Divisor7(int X)
        {
            return X % 7==0;
        }

        public static bool Divisor10(int X)
        {
            return X % 10 == 0;
        }
        public static bool NamesOver4(string name)
        {
            return name.Length >= 4;
        }
    }
}
