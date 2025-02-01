using System;
using System.Reflection.Metadata.Ecma335;
using ADV04.Delegate;

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
            //List<int> list = Enumerable.Range(1, 100).ToList();
            //List<int> EvenNumbers = Helper.GetNumberBasedonCondition(list, Conditions.EvenNumber);
            //Console.WriteLine("Even Numbers");
            //foreach (int i in EvenNumbers)
            //{
            //    Console.Write($"{i} ");
            //}
            //List<int> OddNumbers = Helper.GetNumberBasedonCondition(list, Conditions.OddNumber);
            //Console.WriteLine("\n Odd Numberss");
            //foreach (int i in OddNumbers)
            //{
            //    Console.Write($"{i} ");
            //}
            //List<int> DivisableBy7 = Helper.GetNumberBasedonCondition(list, Conditions.Divisor7);
            //Console.WriteLine("\nDivisableBy7 Number");
            //foreach (int i in DivisableBy7)
            //{
            //    Console.Write($"{i} ");
            //}
            //List<int> DivisableBy10 = Helper.GetNumberBasedonCondition(list, Conditions.Divisor10);
            //Console.WriteLine("\nDivisableBy10 Number");

            //foreach (int i in DivisableBy10)
            //{
            //    Console.Write($"{i} ");
            //}
            #region withGeneric
            //List<string> Names = new List<string> { "Ahmed", "Mohamed", "Manar", "ali", "Mai" };
            //List<string> NamesOver4 = Helper.GetNumberBasedonCondition<string>(Names, Conditions.NamesOver4);
            //foreach (string result in NamesOver4)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion
            #endregion

            #region Built in Delegate
            //1-Predicate:refer to function that take one parameter only and return bool
            //2-Func:can refer to function that can take [0-16] parameters and must be retrun
            //3Action:refer to function take [0-16] parameter andmust be void
            #region Example
            //Predicate<int> predicate = TestingFunctions.Test1;
            //Console.WriteLine(predicate(21));
            //Console.WriteLine("------------");
            //Func<int, string> func = TestingFunctions.Casting;
            //string result = func(10);
            //Console.WriteLine(result);
            //Console.WriteLine("--------------");
            //Action action = TestingFunctions.Print;
            //action();
            //Console.WriteLine("--------------");
            //Action<string> action1= TestingFunctions.Print;
            //action1("Ahmed");
            #endregion
            #endregion

            #region Anonymous Method
            //Predicate<int> predicate = delegate (int X) { return X > 0; } ; 
            //Console.WriteLine(predicate( 21 ));
            //    Func<int, string> func = delegate (int X) { return X.ToString(); };
            //    string result = func(10);
            //    Console.WriteLine("------------");
            //    Console.WriteLine(result);
            //    Console.WriteLine("--------------");
            //    Action action = delegate  
            //{
            //    Console.WriteLine("Hello World"); ;
            //};
            //action();
            //    Console.WriteLine("--------------");
            //    Action<string> action1 = delegate (string Name)
            //{
            //    Console.WriteLine($"Hello {Name}");
            //};
            //action1("Ahmed");
            #endregion

            #region Lambda Expression
            //Predicate<int> predicate = X=>    X > 0;
            //Console.WriteLine(predicate(21));
            //Console.WriteLine("------------");
            //Func<int, string> func = Number=>Number.ToString();
            //string result = func(10);
            //Console.WriteLine(result);


            //Console.WriteLine("--------------");
            //Action action = () =>  Console.WriteLine("Hello World"); 
            //action();
            //Console.WriteLine("--------------");
            //Action<string> action1 = Name => Console.WriteLine($"Hell {Name}");
            //action1("Ahmed");
            #endregion

            #region List Methods
            //      List<int> Numbers =new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //      bool result = Numbers.Exists(X => X ==  10);
            //      Console.WriteLine(result);
            //int Element= Numbers.Find(X => X %2 ==0);
            //      Console.WriteLine(Element);
            //      Numbers.ForEach(X => Console.Write ($"{++X} "));
            #endregion

            #region Function Return Function
        //  Action action=  FunctionReturnDelegate.ActionDelegate();
        //    action();

        //string Name= FunctionReturnDelegate.FuncDelegate()(['a', 'b', 'd', 'o']);
        //    Console.WriteLine(Name);

        //bool result=FunctionReturnDelegate.PredicateDelegate()(10);
        //    Console.WriteLine(result);
            #endregion
        }
    }
}
