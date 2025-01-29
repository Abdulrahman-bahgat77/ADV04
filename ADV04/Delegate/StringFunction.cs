using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04.Delegate
{
    internal class StringFunction
    {
        public static int GetUpper(string Name)
        {
            int Counter = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsUpper(Name[i]))
                        Counter++;
                }
            }
            return Counter;
        }

        public static int GetLower(string Name)
        {
            int Counter = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsLower(Name[i]))
                        Counter++;

                }
            }
            return Counter;
        }
    }
}
