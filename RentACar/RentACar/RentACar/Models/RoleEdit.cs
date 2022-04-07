using Microsoft.AspNetCore.Identity;

namespace RentACar.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<User>? Members { get; set; }
        public IEnumerable<User>? NonMembers { get; set; }
    }
}
