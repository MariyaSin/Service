using Microsoft.EntityFrameworkCore;
using Service.ModeldsDB;
using System.Reflection;

namespace Service.SQL
{
    public class ServiceDBContext : DbContext
    {
        public DbSet<DbUser> UsersService { get; set; }
        public ServiceDBContext(DbContextOptions<ServiceDBContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=ServiceDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
