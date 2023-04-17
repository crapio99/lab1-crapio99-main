using Lab1.Models;

namespace Lab1.Service
{
    public interface IVehicleCostCalculator
    {
        decimal CalculateCost(Vehicle vehicle, int milesDriven);

    }
}
