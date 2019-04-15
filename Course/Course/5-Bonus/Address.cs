namespace Course._5_Bonus
{
    public enum AddressType
    {
        Home,
        Work
    }

    public class Address
    {
        public int Name { get; set; }
        public AddressType Type { get; set; }
    }
}