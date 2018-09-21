namespace Core.Models
{
    public class Vehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}