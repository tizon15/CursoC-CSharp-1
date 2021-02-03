using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Legacy.Legacy
{
    class Coche : Vehiculo
    {
        public Coche(String nombreCoche) : base(nombreCoche) {}
        public override void arrancarMotor()
        {
            Console.WriteLine("Arrancamos el motor del coche");
        }
        public override void pararMotor()
        {
            Console.WriteLine("Paramos el motor del coche");
        }
    }
}
