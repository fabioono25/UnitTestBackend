using System;

namespace Course._2_Fundamentals
{
    /// <summary>
    /// 1 - Implement unitTest methods for this class
    /// 2 - This method needs to throws an exception based on a max velocity (in this case, must be 300km)-refactor the method and create the unittest
    /// 3 - Go to Stack class
    /// </summary>    
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 65;

        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException();

            if (speed <= SpeedLimit) return 0;

            const int kmPerDemeritPoint = 5;
            var demeritPoints = (speed - SpeedLimit) / kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}
