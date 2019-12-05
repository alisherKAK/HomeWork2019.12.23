using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace asp.net_Auth.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<User>  Users { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}