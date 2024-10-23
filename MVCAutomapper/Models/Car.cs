namespace MVCAutomapper.Models
{
    public class Car
    {
        public string Brand { get; set; } = default!;
        public int Power { get; set; }
        public string Model { get; set; } = default!;
        public decimal Price { get; set; }
    }
}
