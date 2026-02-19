using System;

namespace bucles
{
   internal class Program
 {
        static void Main(string[] args)
        {
            /* //Ejemplo de bucle for
              for (int i = 0; i < 10; i++)
              {
                 Console.WriteLine($"Iteración {i}");
                }*/


            //Foreach: es un tipo de bucle que se utiliza para 
            // recorrer elementos de una colección, 
            //como un array o una lista.
            // int [] numeros = { 1, 2, 3, 4, 5 };

            // foreach (int n in numeros) // n en singular porque representa un solo elemento de la colección
            // {
            //     Console.WriteLine("Numero:" + n);


            // List<string> nombres = new List<string> { "Ana", "Luis", "Maria", "Pedro"};

            // foreach (string nombre in nombres)
            // {
            //      Console.WriteLine("HOLA: " + nombre);
            // }   

            //Ciclo While: es un tipo de bucle que se ejecuta mientras una condición sea verdadera.
            // int num = 0;
            // while (num < 5)
            //     {
            //         Console.WriteLine(num);
            //         num++;

            //     }

                /*/ Ciclo Do-While: Es un bucle que se ejecuta al menosunaves, 
                //ya que la condicion se evalua al final de codigo.
                // Se usa cuando queremos aseguararnos de que el bloque de codigo
                //se ejecute al menos una vez, 
                //independientemente de la condición inicial.
                int opcion;
                do
                {
                    Console.WriteLine ("INgrese un numero positivo");
                    int.TryParse(Console.ReadLine(), out opcion);
                } while (opcion <= 0); // la condicion es que el numero sea menor o igual a 0, es decir, mientras el numero no sea positivo, el bucle se repetira
                */

        }
    }
}       
