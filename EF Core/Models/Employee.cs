using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public bool IsActive{ get; set; }
    }
}
