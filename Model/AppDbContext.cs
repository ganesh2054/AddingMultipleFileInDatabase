using Microsoft.EntityFrameworkCore;


namespace WebApplication2.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>option):base(option)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Photo> Photoo { get; set; }
    }
}
