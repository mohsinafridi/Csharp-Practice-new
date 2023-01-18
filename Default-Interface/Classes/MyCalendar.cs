namespace Default_Interface.Classes
{
    public class MyCalendar : IYearCalendar, IMonthCalendar
    {
        // Creating object
        MyCalendar t = new MyCalendar();
        public DateTime Date { get; set; }
        DateTime ICalendar.Date { get => Date; set => Date = value; }


        public string ShowMessage()
        {
            return $"Today is {Date}";
        }

    }
}
