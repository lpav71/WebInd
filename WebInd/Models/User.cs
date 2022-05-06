using Microsoft.AspNetCore.Identity;

namespace WebInd.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
