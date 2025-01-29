namespace ADV04
{
    internal class Program
    {
        //0-Declear Delegate
        public delegate int StringFunctionDelegate(string str);
        //New Class[Delegate]
        //Any Reference in Delegate can refer to Any Function Or More(Point To Function)
        //This Function Can Be Static
        //This Function Can Be Non Static
        //These Function Must Be With Signture 
         
        static void Main(string[] args)
        {
            #region Delegate
            //1-Declare Reference from delegate
            //StringFunctionDelegate stringfunc;
            //2-Inrailize Reference from Delegate
            //stringfunc = StringFunction.GetLower;
            //3-Use
            //int result= stringfunc.Invoke("Omar ALii");
            // Console.WriteLine(result);
            #endregion 

            #region Example01
            //int[] Numbers = { 10, 2, 4, 2, 8, 5, 7, 1, 9, 6 };
            //SortingFunction<int>.BubbleSort(Numbers, CompareFunction.CompareLess);
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------------------------------");
            #endregion
            
            #region Example02
            //string[] Names = { "amr", "alaa", "abdo", "manomoo" };
            //SortingFunction<string>.BubbleSort(Names, CompareFunction.stringAsc);
            //foreach (string s in Names)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Example03
            List<int> list = Enumerable.Range(1,100).ToList();
            
           foreach(int i in list)
            {
                Console.Write($"{i} ||");
            }
            #endregion

        }
    }
}
