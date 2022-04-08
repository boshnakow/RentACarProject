namespace RentACar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Seats { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsOrdered { get; set; }
        public string FullName 
        {
            get
            {
                return $"{Brand} {Model}";
            }
        }
    }
}
