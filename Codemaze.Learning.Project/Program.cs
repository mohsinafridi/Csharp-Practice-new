
using Codemaze.Learning.Project.Models;
using System.Data;
using System.Data.SqlClient;



var context = new EmployeeDbContext("Data Source=AEADLT19726;Initial Catalog=Learning;User ID=sa;Password=xxx");
// IEnumerable<Employee> employees = context.Employees.Where(e => e.Id > 1);
IQueryable<Employee> employees = context.Employees.Where(e => e.Id > 1);
//var topEmployees = employees.Take(2);

foreach (var emp in employees)
{ 
     Console.WriteLine($"Name -   {emp.FirstName} {emp.LastName} has Address  { emp.Address}");
}

// Bulk Insert into Database.
// using var connection_01 = new SqlConnection(Environment.GetEnvironmentVariable("Connection"));
/*
using var connection = new SqlConnection("Data Source=AEADLT19726;Initial Catalog=Learning;User ID=sa;Password=xxx");

var table = new DataTable();
table.Columns.Add("Id");
table.Columns.Add("Name");
table.Columns.Add("Description");
table.Columns.Add("Type");

for (int count = 0; count < 100; count++)
{
    table.Rows.Add(new object[] 
    {
        count + 1 ,
        "Name" + count,
        "Description" + count,
        "Type" + count 
    });
}


using var bulkCopy = new SqlBulkCopy(connection);
bulkCopy.DestinationTableName = "Product";
bulkCopy.BatchSize = 100;
bulkCopy.BulkCopyTimeout = 60;
connection.Open();
bulkCopy.WriteToServer(table);
*/