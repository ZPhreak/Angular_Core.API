using Microsoft.EntityFrameworkCore;

namespace Angular_Core.API.DataModels
{
    public class AngularCoreContext : DbContext
    {
        public AngularCoreContext(DbContextOptions<AngularCoreContext> options): base(options)
        {
            
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
