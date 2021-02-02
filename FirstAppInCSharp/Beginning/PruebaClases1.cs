using System;

namespace FirstAppInCSharp
{
    /*
    *  Esta clase corresponde a todo lo aquirido y apuntado que me parecía de mi interés del inicio del curso     
    */
    class PruebaClases1
    {
        public static void Inicio()
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
            Console.WriteLine(Suma(5, 7));
            Console.WriteLine("-----------------------------------------------");
            PrimerMetodo();
        }
        // CAMPOS DE CLASE
        // SON LAS VARIABLES QUE SON ACCESIBLES DESDE CUALQUIER LADO SI ESTÁN EN AMBITO DE CLASE Y NO DE MÉTODO 
        static int val1 = 2;
        static int val2 = 3;
        // POR CONVENCIÓN LOS METODOS TIENEN QUE DECLARARSE EN MAYÚSCULAS
        static void PrimerMetodo()
        {
            int numero1 = 5;
            int numero2 = 7;
            Console.WriteLine(val1 + val2);
            Console.WriteLine("----------------------------------------------------------------");
            SegundoMetodo(numero1, numero2);
        }

        static void SegundoMetodo(int numero1, int numero2) => Console.WriteLine(numero1 + numero2);

        // LA NOMENCLATURA ABREVIADA "=>" SE LLAMA EXPRESSION-BODIED
        // SIRVE COMO ABREVIATURA SI UN MÉTODO TIENE SOLO UNA LINEA DE EXPRESIÓN 
        static int Suma(int operador1, int operador2) => operador1 + operador2;

        static int Suma(int val1, int val2, int val3) => val1 + val2 + val3;
    }
}
