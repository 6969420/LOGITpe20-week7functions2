using System;

namespace šomething
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter C for Fahrenheit to Celsius or f for Celsius to Fahrenheit");
            string userInput = Console.ReadLine();

            if(userInput == "C")
            {
                ToCelsius();
            }else
            {
                ToFahrenheit();
            }
        }
        public static void ToCelsius()
        {
            Console.WriteLine("enter the temperature in F: ");
            int tempF = Int32.Parse(Console.ReadLine());
            double result = (tempF - 32) * 5 / 9;
            Console.WriteLine($"Result in Celcius: {result}");
        }

        public static void ToFahrenheit()
        {
            Console.WriteLine("enter the temperature in C: !");
            int tempC = Int32.Parse(Console.ReadLine());
            double result = (tempC * 9) / 5 + 32;
            Console.WriteLine($"Result in Fahrenheit: {result}");
        }
    }
}
