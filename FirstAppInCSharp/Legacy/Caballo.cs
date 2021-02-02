using System;

namespace FirstAppInCSharp.Legacy
{
    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo): base(nombreCaballo) {}
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
}
