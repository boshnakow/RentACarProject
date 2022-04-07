using Microsoft.AspNetCore.Identity;
namespace RentACar.Models
{
    public class User:IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string EGN { get; set; }
    }
}
