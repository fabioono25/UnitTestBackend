namespace Course._2_Fundamentals
{
    /// <summary>
    /// You'll need to implement unit test for methods that returns an objet
    /// 1 - TypeOf<T> (exactly the object)
    /// 2 - InstanceOf (the object or derivatives) 
    /// 3 - Go to ErrorLogger class
    /// </summary>
    public class CustomerController
    {
        public ActionResult GetCustomer(int id)
        {
            if (id == 0)
                return new NotFound();

            return new Ok();
        }
    }

    public class ActionResult { }

    public class NotFound : ActionResult { }

    public class Ok : ActionResult { }
}
