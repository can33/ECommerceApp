using Microsoft.AspNetCore.Identity;

namespace ECommerceApp.Core.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
