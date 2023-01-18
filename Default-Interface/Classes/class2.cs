namespace Default_Interface.Classes
{
    public class class2 : ICalendar
    {
        public DateTime Date { get; set;  }

        internal string ShowMessage1()
        {
            throw new NotImplementedException();
        }

        string ICalendar.ShowMessage1()
        {
            return "Class - 2" + Date;
        }
    }
}
