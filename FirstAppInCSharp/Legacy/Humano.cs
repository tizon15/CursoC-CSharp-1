﻿using System;

namespace FirstAppInCSharp.Legacy
{
    class Humano : Mamiferos
    {
        public Humano (String nombreHumano): base(nombreHumano) {}
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }
}
