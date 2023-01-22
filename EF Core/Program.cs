using EF_Core;
using EF_Core.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


var config = new ConfigurationBuilder().AddUserSecrets<YourClassName>().Build();
var connectionString = config.GetSection("Connectionstring").Value;



//builder.Configuration.AddEnvironmentVariables()
//                     .AddKeyVault()
//                     .AddUserSecrets(Assembly.GetExecutingAssembly(), true);

//var builder = new ConfigurationBuilder()
//.SetBasePath(Directory.GetCurrentDirectory())
//.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//.AddUserSecrets<YourClassName>()
//.AddEnvironmentVariables();

//var services = new ServiceCollection()
//.Configure<YourClassName>(Configuration.GetSection(nameof(YourClassName)))
//.AddOptions()
//.BuildServiceProvider();

//services.GetService<SecretConsumer>();

// Test Raw Queries.
/*
   var sqlRaw = SqlRaw.TestRawQuery();
   Console.WriteLine(sqlRaw);
*/



// EF New Functionality Testing

// 1 . Global Filter in EF Queries.




