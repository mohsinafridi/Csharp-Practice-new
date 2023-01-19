using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemaze.Learning.Project.Models
{
    public class EmployeeDbContext : DbContext
    {
        private readonly string connectionString;
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
    }
}
