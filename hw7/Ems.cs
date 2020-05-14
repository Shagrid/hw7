namespace hw7
{
    public class Ems : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 3;
        }
    }
}