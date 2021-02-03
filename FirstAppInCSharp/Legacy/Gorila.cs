using System;

namespace FirstAppInCSharp.Legacy
{
    class Gorila : Mamiferos
    {
        public Gorila (String nombreGorila) : base(nombreGorila) { }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }
}
