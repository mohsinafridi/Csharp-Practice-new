using EF_Core.Models;
using Microsoft.EntityFrameworkCore;


namespace EF_Core
{
    public class SqlRaw
    {
        private readonly EmployeeDbContext context;
        public SqlRaw(EmployeeDbContext context)
        {
            this.context = context;
        }
        public static async Task<bool> TestRawQuery()
        {
            const int employeeId = 888;

            var context = new EmployeeDbContext("Data Source=MOHSIN\\SQLEXPRESS;Initial Catalog=Learning;User ID=sa;Password=Prompt@7788");

            var employee = await context.Employees
                              .FromSqlRaw("Select * from Employee where FirstName = 'FirstName - 999'")
                              .FirstOrDefaultAsync();

            // Stored Procedure

            var sp_Employees = await context.Employees.FromSqlRaw("EXEC GetEmployess")
                              .ToListAsync();

            var sp_EmployeeById = context.Employees.FromSqlRaw($"EXEC GetEmployeeById @Id = {employeeId}").ToList();
            // var employeeAsNoTracking = await context.Employees.AsNoTracking().FirstOrDefaultAsync(x=>x.FirstName == "FirstName - 999");


            Console.WriteLine("Employee {0}", employee?.FirstName);
            Console.WriteLine("Employee By ID {0}", sp_EmployeeById);
            return true;
        }
    }
}
