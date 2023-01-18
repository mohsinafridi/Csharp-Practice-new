using ref_and_out;

// Declaring variable 
// without assigning value 
public class Program
{
    public static void Main(string[] args)
    {
        int G; // out
        string str = "Geek"; // ref

        
        Sum(out G); // Pass variable G to the method using out keyword 
        SetValue(ref str);// Pass as a reference parameter 

        // Display the value G 
        Console.WriteLine("The sum of the value is: {0}", G);
        // Display the given string 
        Console.WriteLine("ref string is {0}" , str);
    }

    public static void Sum(out int G)
    {
        G = 80;
        G += G;
    }
    static void SetValue(ref string str1)
    {

        // Check parameter value 
        if (str1 == "Geek")
        {
            Console.WriteLine("Hello!!Geek");
        }

        // Assign the new value 
        // of the parameter 
        str1 = "GeeksforGeeks";
    }

}