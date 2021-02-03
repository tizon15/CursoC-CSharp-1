using FirstAppInCSharp.Legacy;
using System;

namespace FirstAppInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PruebaClases1.Inicio();

            // PROGRAMACION ORIENTADA A OBJETOS
            Console.WriteLine("-------------------------------------------------------");
            //Creación de objeto tipo POO_II_Circulos. Variable/objeto de tipo circulo.
            OOP_II_Circulos miCirculo;

            // INICIACION DE VARIABLE/OBJETO DEL TIPO DE LA CLASE CORRESPONDIENTE
            // INSTANCIA DE LA CLASE
            // miCirculo = NOMBRE INSTANCIA
            miCirculo = new OOP_II_Circulos();

            Console.WriteLine(miCirculo.calculoArea(5));

            Console.WriteLine("-------------------------------------------------------");


            /*
             * PROYECTO HERENCIA
             */
            Caballo Rocinante = new Caballo("Rocinante");
            Humano Juan = new Humano("Juan");
            Gorila Terk = new Gorila("Terk");

            Rocinante.galopar();
            Console.WriteLine("-------------------------------------------------------");
            Juan.cuidarCrias();
            Console.WriteLine("-------------------------------------------------------");
            Terk.trepar();
            Console.WriteLine("-------------------------------------------------------");
            Rocinante.getNombre();
            Console.WriteLine("-------------------------------------------------------");
            Juan.getNombre();
            Console.WriteLine("-------------------------------------------------------");
            Terk.getNombre();
            Console.WriteLine("-------------------------------------------------------");


            // PRINCIPIO DE SUSTITUCION
            Mamiferos animal = new Mamiferos("Yegua");
            Caballo Yegua = new Caballo("Yegua");
            animal = Yegua;
            animal.getNombre();

            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = Rocinante;
            almacenAnimales[1] = Juan;
            almacenAnimales[2] = Terk;
            Console.WriteLine("-------------------------------------------------------");
            almacenAnimales[1].getNombre();


            Console.WriteLine("-------------------------------------------------------");
            for(int i = 0; i<3;i++)
            {
                almacenAnimales[i].pensar();
            }
        }
    }

   
}