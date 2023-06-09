using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Wpisz Liczbę a");
        a = (int)inputValue();
        Console.WriteLine("Wpisz liczbę b");
        b = (int)inputValue();
        Console.WriteLine("Liczbą większą jest liczba");
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
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

