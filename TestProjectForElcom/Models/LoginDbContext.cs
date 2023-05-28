using Microsoft.EntityFrameworkCore;

namespace TestProjectForElcom.Models
{
    public class LoginDbContext:DbContext 
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options):base(options)
        {

        }
        public DbSet<Login> Login { get; set; }
    }
}
