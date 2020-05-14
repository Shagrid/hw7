namespace hw7
{
    public class FedEx : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5;
        }
    }
}