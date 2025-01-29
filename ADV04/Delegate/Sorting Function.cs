using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04.Delegate
{
    public delegate bool CompareFuncDelegate<T>(T A, T B);
    internal class SortingFunction<T>
    {
        public static void BubbleSort(T[] arr, CompareFuncDelegate<T> comparedelegate)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        //if (arr[j] > arr[j + 1])
                        if (comparedelegate(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);

                    }
                }
            }
        }



        private static void Swap(ref T v1, ref T v2)
        {
            T Temp;
            Temp = v1;
            v1 = v2;
            v2 = Temp;
        }
    }
}
