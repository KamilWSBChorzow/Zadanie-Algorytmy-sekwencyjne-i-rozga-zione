using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj P");
        double p;
        
        p = inputValue();
        double r;
        
        r = Math.Sqrt(p / Math.PI);
        Console.WriteLine(r);
        int o;
        
        o = (int) (2 * Math.PI * r);
        Console.WriteLine("Pole koła wynosi:" + o);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
