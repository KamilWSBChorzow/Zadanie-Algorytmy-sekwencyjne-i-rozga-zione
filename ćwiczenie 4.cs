using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double a, b, c, d, xy;

                Console.WriteLine("X/Y = (a/b)+(c/d)");

                Console.WriteLine("Podaj a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj b");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj d");
                d = int.Parse(Console.ReadLine());

                xy = (a / b) + (c / d);

                if (d == 0)
                {
                    Console.WriteLine("Brak rozwiazan. D nie moze byc rowne 0 !");
                }
                if (b == 0)
                {
                    Console.WriteLine("Brak rowiazan. B nie moze byc rowne 0 !");
                }
                else
                {
                    Console.WriteLine("X/Y = ");
                    Console.WriteLine(xy);
                }
            }
        }
    }
}
