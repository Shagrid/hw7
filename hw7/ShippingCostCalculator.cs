using System;

namespace hw7
{
    public class ShippingCostCalculator
    {
        public double ShippingCostCalculator(Order order)
        {
            switch (order.ShippingMethod)
            {
                case ShippingOptions.FedEx:
                    return CalculateForFedEx(order);

                case ShippingOptions.UPS:
                    return CalculateForUPS(order);

                case ShippingOptions.EMS:
                    return CalculateForEMS(order);

                default:
                    throw new Exception("Неизвестный сервис");
            }
        }

        double CalculateForEMS(Order order)
        {
            return 3;
        }

        double CalculateForUPS(Order order)
        {
            return 4;
        }

        double CalculateForFedEx(Order order)
        {
            return 5;
        }
    }

}