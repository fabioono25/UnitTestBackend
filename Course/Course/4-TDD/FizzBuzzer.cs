using System;

namespace Course._4_TDD
{
    public class FizzBuzzer
    {
        public string GetValue(int input)
        {
            if (input % 3 == 0)
                return "Fizz";

            return input.ToString();
        }
    }
}
