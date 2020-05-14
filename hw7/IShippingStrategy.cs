namespace hw7
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}