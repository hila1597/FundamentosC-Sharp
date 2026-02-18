using System;

namespace Semana1App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre:");
            string nombre = Console.ReadLine() ?? "";

            Console.WriteLine("Ingresa tu edad:");
            int edad = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Hola {nombre}, tienes {edad} años.");

            int edadFutura = edad + 5;
            Console.WriteLine($"En 5 años tendrás {edadFutura} años.");

            if (edad >= 18)
                Console.WriteLine("Eres mayor de edad.");
            else
                Console.WriteLine("Eres menor de edad.");
        }
    }
}
