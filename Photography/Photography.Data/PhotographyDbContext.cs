using System.Reflection;
using Photography.Data.Models;

namespace Photography.Data
{
    using Microsoft.EntityFrameworkCore;
    public class PhotographyDbContext : DbContext
    {
        public PhotographyDbContext()
        {

        }

        public PhotographyDbContext(DbContextOptions options)
        :base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
