using CQRSandMediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSandMediatRDemo.Data
{
    public class DataDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<StudentDetails> Students { get; set; }
    }
}
