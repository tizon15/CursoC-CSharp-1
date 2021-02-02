using System;

namespace FirstAppInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PruebaClases1.Inicio();
            Console.WriteLine("-------------------------------------------------------");
            //Creación de objeto tipo POO_II_Circulos. Variable/objeto de tipo circulo.
            POO_II_Circulos miCirculo;

            // INICIACION DE VARIABLE/OBJETO DEL TIPO DE LA CLASE CORRESPONDIENTE
            // INSTANCIA DE LA CLASE
            miCirculo = new POO_II_Circulos();

            Console.WriteLine(miCirculo.calculoArea(5));
        }
    }

   
}