
using Codemaze.Learning.Project.Models;
using System.Data;
using System.Data.SqlClient;



//var context = new EmployeeDbContext("Data Source=AEADLT19726;Initial Catalog=Learning;User ID=sa;Password=Prompt@7788");
// IEnumerable<Employee> employees = context.Employees.Where(e => e.Id > 1);
//IQueryable<Employee> employees = context.Employees.Where(e => e.Id > 1);
//var topEmployees = employees.Take(2);

//foreach (var emp in employees)
//{ 
//     Console.WriteLine($"Name -   {emp.FirstName} {emp.LastName} has Address  { emp.Address}");
//}

// Bulk Insert into Database.
// using var connection_01 = new SqlConnection(Environment.GetEnvironmentVariable("Connection"));

using var connection = new SqlConnection("Data Source=MOHSIN\\SQLEXPRESS;Initial Catalog=Learning;User ID=sa;Password=Prompt@7788");

var table = new DataTable();
table.Columns.Add("Id");
table.Columns.Add("FirstName");
table.Columns.Add("LastName");
table.Columns.Add("Address");

for (int count = 0; count < 1000; count++)
{
    table.Rows.Add(new object[] 
    {
        count + 1 ,
        "FirstName - " + count,
        "LastName - " + count,
        "Address - " + count 
    });
}


using var bulkCopy = new SqlBulkCopy(connection);
bulkCopy.DestinationTableName = "Employee";
bulkCopy.BatchSize = 1000;
bulkCopy.BulkCopyTimeout = 60;
connection.Open();
bulkCopy.WriteToServer(table);
