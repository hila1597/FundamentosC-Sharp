using System;
using pooclase3;

namespace pooclase3
{
    public class Program
    {
        static void Main (string [] args)
        {
            /**
            Persona persona1 = new Persona();
            Console.WriteLine (persona1.GetNombre() );

            persona1.SetNombre("Maria");
            string nombrePersona1 = persona1.GetNombre();
            persona1.Edad = 30;
            Console.WriteLine ("Modificando el atributo nombre...");
            Console.WriteLine (nombrePersona1);
            Console.WriteLine ($"La  Persona se llama {nombrePersona1} y tiene {persona1.Edad} años.");

            Persona persona2 = new Persona();
            persona2.SetNombre("Jose");
            string nombrePersona2 = persona2.GetNombre();
            persona2.Edad = 30;

            Console.WriteLine ($"La Persona se llama {nombrePersona2} y tiene {persona2.Edad} años.");
            
            Persona persona3 = new Persona("Ana", 21);
            Console.WriteLine ($"La Persona se llama {persona3.GetNombre()} y tiene {persona3.Edad} años.");

            **/

            Estudiante estudiante1 = new Estudiante ("Ing. Informatica");
            estudiante1.SetNombre("Jeffry");
            estudiante1.Edad = 35;

            estudiante1.MostrarInformacion();
        }

    
    }
}