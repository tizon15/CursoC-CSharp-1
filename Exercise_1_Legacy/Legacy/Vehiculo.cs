using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1_Legacy.Legacy
{
    class Vehiculo
    {
        private string vehiculo;
        public Vehiculo(String nombre)
        {
            vehiculo = nombre;
        }
        public virtual void arrancarMotor()
        {
            Console.WriteLine("Arrancamos motores");
        }
        public virtual void pararMotor()
        {
            Console.WriteLine("paramos motores");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("El vehículo que estamos conduciendo es: " + vehiculo);
        }
    }
}
