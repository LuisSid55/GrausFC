using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.WriteLine("\n--Conversor de °F para °C--");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n°F: ");
            f = Convert.ToDouble(Console.ReadLine());

            c = (f - 32) / 1.8;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n {f}°F equivale a {c}°C\n");
            Console.ResetColor();
        }
    }
}
