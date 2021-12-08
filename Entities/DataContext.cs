using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TechicalTest.Entities;

namespace TechicalTest
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("user id=TechnicalTestDB;password=4CM5W7BYcB56i73e;server=198.244.148.93;port=3306;database=TechnicalTestDB;pooling=true", ServerVersion.AutoDetect(Configuration.GetConnectionString("TTDatabase")));

        }


        public DbSet<User> Users { get; set; }
    }
}
