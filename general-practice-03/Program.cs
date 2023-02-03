
using general_practice_03;

//var person = new Person("John Doe", 30, "Software Developer");
// Console.WriteLine(person.ToString());



//var inputString = "Saturday";
//DayOfWeek inputAsEnum = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), inputString);
//Console.WriteLine(inputAsEnum);




// USING TUPLE
// learntuple.cs

var tupleResult = learntuple.ParseFirstAndLastName("Mohsin Azam");
Console.WriteLine("Tuple Result is: " + tupleResult);

int qq = learntuple.IndexOfNth("Mohsin Azam Afridi"," ", 3); 


learntuple.ParseFirstAndLastNameWithOutTuple("Mohsin Azam", out string fName, out string lName);

Console.WriteLine("FirstName is: " + fName);
Console.WriteLine("LastName is: " + lName);

