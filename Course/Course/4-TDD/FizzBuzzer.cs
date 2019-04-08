using System;

namespace Course._4_TDD
{
    public class FizzBuzzer
    {
        public string GetValue(int value)
        {
            var result = "";

            if (value % 3 == 0)
                result += "Fizz";

            if (value % 5 == 0)
                result += "Buzz";

            if (!string.IsNullOrEmpty(result))
                return result;

            return value.ToString();
        }
    }
}
