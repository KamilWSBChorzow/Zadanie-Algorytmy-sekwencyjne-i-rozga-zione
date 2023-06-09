using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("wprowadz pierwszy bok a");
        a = inputValue();
        Console.WriteLine("wprowadz drugi bok b");
        b = inputValue();
        Console.WriteLine("Wprowadz trzeci bok c");
        c = inputValue();
        if (a + b == 2 * c)
        {
            Console.WriteLine("Mogą utworzyć");
        }
        else
        {
            Console.WriteLine(" Nie mogą utworzyc");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

