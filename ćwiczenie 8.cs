using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                
                Console.WriteLine("Kalkulator");
                

                Console.Write("Wpisz liczbę 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Wpisz liczbę 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wybierz operacje: ");
                Console.WriteLine("\t+ : Dodaj");
                Console.WriteLine("\t- : Odejmij");
                Console.WriteLine("\t* : Pomnóż");
                Console.WriteLine("\t/ : Podziel");
                Console.Write("Wybierz operacje: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Twój wynik to: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Twój wynik to: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Twój wynik to: {num1} * {num2} = " + result);
                        break;
                        case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Twój wynik to: {num1} / {num2} = "  + result);
                        break;
                    
                        
                }
                Console.Write("Czy chciałbyś kontynuować? (T = Tak, N = Nie): ");
            } while (Console.ReadLine().ToUpper() == "T");

            Console.WriteLine("Do zobaczenia");
            Console.ReadKey();
        }
    }
}
