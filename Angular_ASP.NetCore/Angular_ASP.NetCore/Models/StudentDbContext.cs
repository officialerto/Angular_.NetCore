using Microsoft.EntityFrameworkCore;

namespace Angular_ASP.NetCore.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=STUDENT; Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}
