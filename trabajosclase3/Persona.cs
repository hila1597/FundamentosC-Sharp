using System;

namespace pooclase3 // Note: actual namespace depends on the project name.
{
    //public class Persona
    public abstract class Persona
    {
        // Atributos privados
        private string Nombre;

        //Encapsilamiento con propiedades

        public int Edad { get; set; }

        //Constructor sin parámetros
        public Persona()
        {
            this.Nombre = "Juan";
        }
        //Constructor con parámetros

        public void SetNombre(string nuevoNombre)
        {
            this.Nombre = nuevoNombre;
        }
        public string GetNombre() 
        {
            return this.Nombre;
        }

        public abstract void MostrarInformacion();
    }  
}    