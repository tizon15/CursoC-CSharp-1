using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Legacy.Legacy
{
    class Avion : Vehiculo
    {
        public Avion(String nombreAvion) : base(nombreAvion) { }

        public override void arrancarMotor()
        {
            Console.WriteLine("Arrancamos el motor del avión");
        }
        public override void pararMotor()
        {
            Console.WriteLine("Paramos el motor del avión");
        }
    }
}
