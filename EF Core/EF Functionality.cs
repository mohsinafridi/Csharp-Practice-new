using EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace EF_Core
{
    public class EF_Functionality
    {
        private readonly EmployeeDbContext _context;
        public EF_Functionality(EmployeeDbContext context) 
        {
            _context = context;
        } 

        public async Task<Employee> GetEmployeeById(int id) 
        {
            return await _context.Employees.AsNoTracking()
                  .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> GetEmployeeByFirstName(string fName) 
        {
            return await _context.Employees.AsNoTracking()
                     .FirstOrDefaultAsync(e => e.FirstName == fName);
        }

        public async Task<Employee> GetEmployeeByLastName(string lName) 
        {
            return await _context.Employees.AsNoTracking()
                     .FirstOrDefaultAsync(e => e.LastName == lName);
        }

    }
}
