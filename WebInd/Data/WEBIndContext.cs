using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebInd.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebInd.Data
{
    public class WebIndContext : IdentityDbContext<User>
    {
        public WebIndContext(DbContextOptions<WebIndContext> options) : base(options)
        {
            Database.EnsureCreated();
        }     
    }
}
