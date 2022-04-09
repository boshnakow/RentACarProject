using System.ComponentModel.DataAnnotations;
namespace RentACar.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string UserId { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
