using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADV04.Delegate;

namespace ADV04
{
    internal class FunctionReturnDelegate
    {
        public static Action ActionDelegate()
        {
            return delegate { Console.WriteLine("Hello World"); };
        }

        public static Predicate<int> PredicateDelegate()
        {
            return delegate (int X) { return X > 0; };
           // return X => X > 0;

        }

        public static Func<char[], string> FuncDelegate()
        {
            return delegate (char[] Char) { return new string(Char); };
        }
    }
}
