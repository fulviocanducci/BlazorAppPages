using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Data
{
   public class DatabaseContext : DbContext
   {
      public DatabaseContext(DbContextOptions<DatabaseContext> options)
         : base(options) { }

      public DbSet<Car> Car { get; set; }
   }
}
