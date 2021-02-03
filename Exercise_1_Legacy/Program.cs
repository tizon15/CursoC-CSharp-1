using Exercise_1_Legacy.Legacy;
using System;

namespace Exercise_1_Legacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Aston Martin");
            Avion avion = new Avion("Boeing 737");
            Vehiculo[] vehiculos = new Vehiculo[2];

            vehiculos[0] = coche;
            vehiculos[1] = avion;

            foreach (var vehiculo in vehiculos)
            { 
                vehiculo.Conducir(); 
            }
        }
    }
}
