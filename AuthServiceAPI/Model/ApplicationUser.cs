using Microsoft.AspNetCore.Identity;

namespace AuthServiceAPI.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
