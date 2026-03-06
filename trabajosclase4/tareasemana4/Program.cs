using System;                     // Importa funcionalidades básicas de C# como la consola
using System.Collections.Generic; // Permite usar colecciones genéricas como List<T>

namespace RefugioAnimales // Define un espacio de nombres para organizar el código
{
    // Abstracción: clase abstracta que define lo común a todos los animales
    public abstract class Animal // Clase abstracta: no se pueden crear instancias de esta clase
    {
        private string nombre = ""; // Atributo privado: encapsulación
        private int edad;      // Atributo privado: encapsulación

        // Propiedad pública para acceder al nombre
        public string Nombre // Propiedad: permite controlar el acceso al atributo privado
        {
            get { return nombre; } // Getter: devuelve el valor del nombre
            set { nombre = value; } // Setter: asigna un valor al nombre (sin validación en este caso)
        }

        // Propiedad pública para acceder a la edad con validación
        public int Edad // Propiedad: permite controlar el acceso al atributo privado con validación
        {
            get { return edad; } // Getter: devuelve el valor de la edad
            set

            
            {
                if (value > 0) // Validación: la edad debe ser mayor que 0
                    edad = value; // Setter: asigna un valor a la edad si es válido
                else // Si la edad no es válida, se lanza una excepción
                    throw new ArgumentException("La edad debe ser mayor que 0"); // Manejo de errores: se lanza una excepción si la edad no es válida
            }
        }

        // Constructor que inicializa nombre y edad
        public Animal(string nombre, int edad) // Constructor: se llama al crear una instancia de una clase derivada
        {
            Nombre = nombre; // Asigna el nombre usando la propiedad (con validación)
            Edad = edad; // Asigna la edad usando la propiedad (con validación)
        }

        // Método abstracto: cada animal debe implementar su propio sonido
        public abstract void EmitirSonido(); // Polimorfismo: método que se implementará de manera diferente en cada clase derivada
    }

    // Herencia: Perro hereda de Animal
    public class Perro : Animal // Clase Perro que hereda de Animal
    {
        public Perro(string nombre, int edad) : base(nombre, edad) { }  // Constructor que llama al constructor de la clase base (Animal)

        // Polimorfismo: implementación específica del sonido
        public override void EmitirSonido() // Override: se proporciona una implementación específica para el método abstracto de la clase base
        {
            Console.WriteLine($"{Nombre} (Perro) dice: ¡Guau guau!"); // Cada perro emite un sonido diferente, demostrando polimorfismo
        }
    }

    // Herencia: Gato hereda de Animal
    public class Gato : Animal // Clase Gato que hereda de Animal
    {
        public Gato(string nombre, int edad) : base(nombre, edad) { } // Constructor que llama al constructor de la clase base (Animal)

        public override void EmitirSonido() // Override: se proporciona una implementación específica para el método abstracto de la clase base
        {
            Console.WriteLine($"{Nombre} (Gato) dice: ¡Miau!"); // Cada gato emite un sonido diferente, demostrando polimorfismo
        }
    }

    // Herencia: Ave hereda de Animal
    public class Ave : Animal // Clase Ave que hereda de Animal
    {
        public Ave(string nombre, int edad) : base(nombre, edad) { } // Constructor que llama al constructor de la clase base (Animal)

        public override void EmitirSonido() // Override: se proporciona una implementación específica para el método abstracto de la clase base
        {
            Console.WriteLine($"{Nombre} (Ave) dice: ¡Pío pío!"); // Cada ave emite un sonido diferente, demostrando polimorfismo
        }
    }

    class Program //    Clase principal que contiene el método Main, el punto de entrada del programa
    {
        static void Main(string[] args) // Método Main: punto de entrada del programa
        {
            // Polimorfismo: lista que guarda distintos tipos de animales
            List<Animal> refugio = new List<Animal>(); // Se crea una lista de tipo Animal, que puede contener objetos de cualquier clase que herede de Animal

            // Se agregan animales de diferentes clases
            refugio.Add(new Perro("Firulais", 3)); // Se agrega un perro a la lista
            refugio.Add(new Gato("Misu", 2)); // Se agrega un gato a la lista
            refugio.Add(new Ave("Piolín", 1)); // Se agrega un ave a la lista

            // Se recorre la lista y se llama al método EmitirSonido()
            foreach (Animal animal in refugio) // Polimorfismo: cada objeto responde de forma distinta al mismo método
            {
                animal.EmitirSonido(); // Cada objeto responde de forma distinta
            }
        }
    }
}
