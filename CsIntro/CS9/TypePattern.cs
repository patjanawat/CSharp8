namespace TypePatternNamespace
{
    public abstract class Vehicle { }
    public class Car : Vehicle { }
    public class Truck : Vehicle { }

    public static class TollCalculator{
        public static decimal CalculateToll(this Vehicle vehicle) => vehicle switch{
            Car => 2.00m,
            Truck => 7.50m,
            null => throw new ArgumentException(nameof(vehicle)),
            _ => throw new ArgumentException("Unknow type of a vehicle", nameof(vehicle))
        };
    }
}