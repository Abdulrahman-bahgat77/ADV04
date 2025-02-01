using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04.Delegate
{
   //public  delegate bool GetConditionDelegate<T>(T Number);
    internal class Helper
    {
        public static List<T> GetNumberBasedonCondition<T>(List<T> numbers, Predicate<T> GetCondition)
        {
            List<T> result = new List<T>();
            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    //if(number[i] % 2 == 1)
                    if (GetCondition(numbers[i]))
                        result.Add(numbers[i]);
                    
                }
            }
            return result;
        }

        //public static List<int> GetEven(List<int> number)
        //{
        //    List<int> result = new List<int>();
        //    if (number is not null)
        //    {
        //        for (int i = 0; i < number.Count; i++)
        //        {
        //            if (number[i] % 2 == 0)
        //            {
        //                result.Add(number[i]);
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public static List<int> DivisableBy7(List<int> number)
        //{
        //    List<int> result = new List<int>();
        //    if (number is not null)
        //    {
        //        for (int i = 0; i < number.Count; i++)
        //        {
        //            if (number[i] % 7 == 0)
        //            {
        //                result.Add(number[i]);
        //            }
        //        }
        //    }
        //    return result;
        //}


    }
}
