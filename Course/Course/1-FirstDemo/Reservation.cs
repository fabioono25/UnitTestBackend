using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// The objective of this class is describe the first scenarios that we can map inside a method
/// </summary>
namespace Course._1_FirstDemo
{
    class Reservation
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

    class User
    {
        public bool IsAdmin { get; internal set; }
    }
}
