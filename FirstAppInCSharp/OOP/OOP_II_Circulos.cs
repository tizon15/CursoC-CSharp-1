using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppInCSharp
{
    /*
     * Esta clase tiene relación al video 28 del curso
     * Programación orientada a objetos. Creación de clases e instancias
     */
    class OOP_II_Circulos
    {
        // Propiedad de la clase círculo.
        // Campos de clase.
        const double pi = 3.1416;
        // METODO DE CLASE
        public double calculoArea(int radio)
        {
            return Math.PI * radio * radio;
        }
    }
}
