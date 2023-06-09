// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r, odlegloscOdSrodka;

        Console.WriteLine("Podaj X");
        x = inputValue();
        Console.WriteLine("Podaj Y");
        y = inputValue();
        Console.WriteLine("Podaj r");
        r = inputValue();
        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("wpisane wspolrzedne znajduja sie w kole");
        }
        else
        {
            Console.WriteLine("wpisane wspolrzedne nie znajduja sie w promieniu kola");
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

