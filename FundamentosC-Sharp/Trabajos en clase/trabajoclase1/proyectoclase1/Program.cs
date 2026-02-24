using System;

namespace proyectoclase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables basicas
            // int edad = 25;
            // string nombre = "Ana";
            // bool activo = true;
            // double precio = 99.99;

            // Console.WriteLine("Edad: " + edad);
            // Console.WriteLine("Nombre: " + nombre);
            // Console.WriteLine("Activo: " + activo);
            // Console.WriteLine("Precio: " + precio);
            
            //INPUT DEL USUARIO SE USA CONSOLE.READLINE() PARA OBTENER DATOS DEL USUARIO

            // Console.WriteLine("Escribe tu nombre:");// muestra el mensaje en la consola
            // string nombre = Console.ReadLine()!; // guarda lo que el usuario escribe

            // Console.WriteLine("Escribe tu edad:"); // muestra el mensaje en la consola
            // int edad = int.Parse(Console.ReadLine()!); // convierte el texto a número

            // BOOL Y OPERADORES
            // Console.WriteLine("Escribe tu edad:");
            // int edad = int.Parse(Console.ReadLine()!); // aquí declaras la variable
            // bool esMayorDeEdad = edad >= 18;
            // Console.WriteLine("¿Eres mayor de edad?: " + esMayorDeEdad);

            //OPERRADORES ARITMETICOS
            int a = 10;
            int b = 3;

            Console.WriteLine($"a + b = {a + b}"); // Suma → 13
            Console.WriteLine($"a - b = {a - b}"); // Resta → 7
            Console.WriteLine($"a * b = {a * b}"); // Multiplicación → 30
            Console.WriteLine($"a / b = {a / b}"); // División entera → 3
            Console.WriteLine($"a % b = {a % b}"); // Módulo → 1

            //OPERADORES RELACIONALES
            Console.WriteLine($"a == b : {a == b}"); // Igualdad
            Console.WriteLine($"a != b : {a != b}"); // Diferente
            Console.WriteLine($"a < b : {a < b}");   // Menor que
            Console.WriteLine($"a > b : {a > b}");   // Mayor que
            Console.WriteLine($"a <= b : {a <= b}"); // Menor o igual
            Console.WriteLine($"a >= b : {a >= b}"); // Mayor o igual
            
            //OPERRADORES LOGICOS
            bool x = true;
            bool y = false;

            Console.WriteLine("\nLógicos:");
            Console.WriteLine($"x && y : {x && y}"); // AND → false
            Console.WriteLine($"x || y : {x || y}"); // OR → true
            Console.WriteLine($"!x : {!x}");         // NOT → false
            Console.WriteLine($"!y : {!y}");         // NOT → true



        


        //     Console.WriteLine("Escribe tu nombre:");
        //     string nombre = Console.ReadLine()!; // guarda lo que el usuario escribe

        //     Console.WriteLine("Hola " + nombre + ", ¡bienvenido a C#!");

        //     Console.WriteLine("Escribe tu edad:");
        //     int edad = int.Parse(Console.ReadLine()!); // convierte el texto a número

        //     bool esMayorDeEdad = edad >= 18;
        //     Console.WriteLine("¿Eres mayor de edad?: " + esMayorDeEdad);
        // 
        }
    }
}


