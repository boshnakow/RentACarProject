using System.ComponentModel.DataAnnotations;
namespace RentACar.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
