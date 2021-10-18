using System;

namespace SystemGenericDelegates
{
    class Program
    {
       static Func<int, string> PrintNumbersName = x =>
         {
             switch (x)
             {
                 case 1: return "One";
                 case 2: return "Two";
                 case 3: return "Three";
                 default:
                     throw new ArgumentException();
                     
             }
         };

        static void Main() {
            Console.WriteLine( PrintNumbersName(2));
        }
    }
}
