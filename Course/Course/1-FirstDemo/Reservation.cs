/// <summary>
/// The objective of this class is describe the first scenarios that we can map inside a method
/// 1 - we'll create our first test for CanBeCancelledBy method, following the basic conventions
/// 2 - after this, we'll define the other scenarios (how many paths?)
/// 3 - let's refactor our code and take a look at the tests
/// 4 - go to Math class
/// </summary>
namespace Course._1_FirstDemo
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;

            if (MadeBy == user)
                return true;

            return false;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
