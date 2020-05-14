namespace hw7
{
    public class Ups : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 4;
        }
    }
}