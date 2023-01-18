namespace ref_and_out
{
    public class Ref_Out
    {
        public void Sum(out int G)
        {
            G = 80;
            G += G;
        }
    }
}
