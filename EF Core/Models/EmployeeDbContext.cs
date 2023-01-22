using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace EF_Core.Models
{
    public class EmployeeDbContext : DbContext
    {
        private readonly string connectionString = "Data Source=MOHSIN\\SQLEXPRESS;Initial Catalog=Learning;User ID=sa;Password=";
       private readonly ILoggerFactory loggerFactory = LoggerFactory.Create(config => config.AddConsole());
        public EmployeeDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(connectionString);            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasQueryFilter(x => x.IsActive);
        }
    }
}
