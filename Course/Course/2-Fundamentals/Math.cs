using System.Collections.Generic;

namespace Course._2_Fundamentals
{
    /// <summary>
    /// BEGIN WITH THIS CLASS
    /// In this class we'll execute the following things:
    /// 1 - create the Add Test (exercise)
    /// 2 - create the scenarios referenced by Max method
    /// 3 - use the SetUp data annotation to solve the problem of multiple instances
    /// 4 - Max_WhenCalled_ReturnGreatestArgument(int a, int b, int expectedResult) - use TestCase data annotation
    /// 5 - Ignore one of the tests Ignore("")
    /// 6 - Go to HtmlFormatter
    /// 7 - Implement Test to GetOddNumbers method (not empty, count, contain, IsEquivalentTo, Ordered, Unique)
    /// 8 - Go to CustomerController
    /// </summary>
    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}
