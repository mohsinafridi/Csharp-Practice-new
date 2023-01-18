
using general_practice_03;

var person = new Person("John Doe", 30, "Software Developer");
// Console.WriteLine(person.ToString());



var inputString = "Saturday";
DayOfWeek inputAsEnum = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), inputString);
//Console.WriteLine(inputAsEnum);