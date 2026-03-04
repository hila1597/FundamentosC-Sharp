using System;

namespace pooclase3 // Note: actual namespace depends on the project name.
{
    public class Estudiante : Persona
    {
        private string Carrera;
        public Estudiante (string carrera) : base()
        {
            this.Carrera = carrera;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine ($ "Estudiante: {this.GetNNombre()}, Edad: {this.Edad}, Carrera: {this.Carrera}");
        }
    }



}