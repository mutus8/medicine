using Microsoft.AspNetCore.Identity;

namespace proyecto.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
