namespace Default_Interface
{
    public interface ICalendar
    {
        public DateTime Date { get; set; }

        // Default interface method.
        public string ShowMessage()
        {
            return "Default Calendar";
        }

        public string ShowMessage1()
        {
            return "Default Calendar 1";
        }
    }
}
