using Microsoft.Extensions.Configuration;


var config = new ConfigurationBuilder().Build();
var cs = config.GetSection("Connectionstring").Value; // valid


// Test Raw Queries.
/*
   var sqlRaw = SqlRaw.TestRawQuery(cs);
   Console.WriteLine(sqlRaw);
*/



// EF New Functionality Testing

// 1 . Global Filter in EF Queries.




