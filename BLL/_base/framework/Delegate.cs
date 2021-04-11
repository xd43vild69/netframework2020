using System;

namespace BLL.Delegates
{
    internal delegate void TestDelegate(string name);

    public class Delegate
    {
        private void NewFunction(string value1)
        {
            Console.WriteLine($"call delegate function {value1}");
        }

        private string NewSum(int number1)
        {
            return $"The number is {number1}";
        }

        public bool IsGreater(int number1)
        {
            return false;
        }

        public void RunBasicDelegate()
        {
            TestDelegate td = new TestDelegate(NewFunction);
            td("value 1");

            // with an anonymous function
            td = delegate (string value2) { Console.WriteLine($"call delegate anonymous {value2}"); };
            td("value 2");

            // with a lambda expression
            td = name => { Console.WriteLine($"call delegate lambda {name}"); };
            td("value 3");
        }

        public void RunFuncDelegate()
        {
            Func<int, string> TestFuncDelegate = NewSum;
            Console.WriteLine(TestFuncDelegate(1));
        }

        public void RunPredicateDelegate()
        {
            Predicate<int> predicate1 = IsGreater;
            if (!predicate1(1))
            {
                Console.WriteLine("Call predicate delegate");
            }

            predicate1 = name => 2 > 1;

            if (predicate1(1))
            {
                Console.WriteLine("Call predicate delegate with a lambda");
            }
        }

        public void RunActionDelegate()
        {
            Action<string> TestActionDelegate = NewFunction;
            TestActionDelegate("Action");
        }
    }
}