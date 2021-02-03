using System;

namespace FirstAppInCSharp.Legacy
{
    class Humano : Mamiferos
    {
        public Humano (String nombreHumano): base(nombreHumano) {}
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }
}
