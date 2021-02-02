using System;

namespace FirstAppInCSharp.Legacy
{
    class Mamiferos
    {
        private String nombreSerVivo;
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }
        public void getNombre() 
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }
    }
}
