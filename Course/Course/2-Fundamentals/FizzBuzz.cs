namespace Course._2_Fundamentals
{
    public class FizzBuzz
    {
        /// <summary>
        /// 1 - Implement unitTest methods for this class
        /// 2 - Go to DemeritPointsCalculator
        /// </summary>
        public static string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
