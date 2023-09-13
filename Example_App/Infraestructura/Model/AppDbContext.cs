using Microsoft.EntityFrameworkCore;


namespace Example_App.Infraestructura.Model
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> user { get; set; }

    }
}
