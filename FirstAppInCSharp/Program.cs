using System;

namespace FirstAppInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comentario simple
            /* Comentario 
             * de varias
             * lineas */
            //Console.WriteLine("Bienvenidos al curso de C#");

            // DECLARACION VARIABLES

            /* Las variables tienen que iniciarse en algún punto antes de poder usarse*/
            int edad;
            edad = 23;
            Console.WriteLine("Mi edad: " + edad);
            Console.WriteLine("-------------------------------------------------------------");
            edad++;
            //Interpolación de strings
            // Para la interpolación de strings hay que añadir el $ para que sea posible su ejecución
            Console.WriteLine($"Tienes una edad de {edad} años");
            Console.WriteLine("-------------------------------------------------------------");

            /* el incremento de la edad se tiene que hacer antes de imprimir el resultado,
             * si no, no funciona debido a que el codigo va de arriba a abajo e izquierda a derecha*/
            Console.WriteLine("No hay incremento sigues teniendo: " + edad++ + " años");
            Console.WriteLine("-------------------------------------------------------------");

            // COMPORTAMIENTO OPERADOR ASIGNACIÓN
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            //asignar valor a las 4 variables a la vez 
            //Opcion 1
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 23;
            Console.WriteLine("Edad persona 2: " + edadPersona2);
            Console.WriteLine("-------------------------------------------------------------");

            // DECLARACION IMPLICITA
            var edadPersonaImplicita = 27;
            
            Console.WriteLine(edadPersonaImplicita);
            Console.WriteLine("-------------------------------------------------------------");

            //CONVERSION EXPLICITA
            //CASTING
            double temperatura = 34.5;
            int temperaturaMadrid;

            temperaturaMadrid = (int)temperatura;
            Console.WriteLine(temperaturaMadrid);
            Console.WriteLine("-------------------------------------------------------------");

            //CONVERSION IMPLICITA

            int habitantes = 100000;
            long habitantesCiudad = habitantes;

            float pesoMaterialFloat = 5.78F;

            double pesoMaterialDouble = pesoMaterialFloat;
            Console.WriteLine("habitantesCiudad: {0}" + " pesoMaterialDouble: {1}", habitantesCiudad, pesoMaterialDouble);
            Console.WriteLine("-------------------------------------------------------------");

            
            



        }
    }
}
