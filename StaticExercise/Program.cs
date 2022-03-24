using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(50);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(10);

            Console.WriteLine(":After conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");


        }
    }
}
