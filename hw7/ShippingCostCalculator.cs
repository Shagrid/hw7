using System;

namespace hw7
{
    public class ShippingCostCalculator 
    {
        public double Calculate(Order order, IShippingStrategy strategy)
        {
            return strategy.Calculate(order);

        }
        
    }

}