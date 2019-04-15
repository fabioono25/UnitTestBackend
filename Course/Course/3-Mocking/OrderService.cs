namespace Course._3_Mocking
{
    /// <summary>
    /// 1 - Implement the unit tests
    /// 2 - Go to 4-TDD -> Readme.txt
    /// </summary>
    public class OrderService
    {
        private readonly IStorage _storage;

        public OrderService(IStorage storage)
        {
            _storage = storage;
        }

        public int PlaceOrder(Order order)
        {
            var orderId = _storage.Store(order);

            // Some other work

            return orderId;
        }
    }

    public class Order
    {
    }

    public interface IStorage
    {
        int Store(object obj);
    }
}
