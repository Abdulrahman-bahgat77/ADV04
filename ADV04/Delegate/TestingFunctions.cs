using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04.Delegate
{
    internal   class TestingFunctions
    {
        public static bool Test1(int X)
        {
            return X > 0;
        }
        public static string Casting(int X)
        {
            return X.ToString();
        }

        public static void Print()
        {
            Console.WriteLine("Hello World");  ;
        }

        public static void Print(string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }
    }
}
