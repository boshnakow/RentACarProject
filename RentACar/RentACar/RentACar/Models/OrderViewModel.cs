namespace RentACar.Models
{
    public class OrderViewModel
    {
        public int CarId { get; set; }
        public List<Car> Cars { get; set; }
        public int UserId { get; set; }
        public List<User> Users { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
