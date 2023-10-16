using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica22
{
    internal class Opcion1
    {
        public static void Inicializar()
        {
            int capacidadVector = 15; // Capacidad máxima del vector

            int[] numeroFactura = new int[capacidadVector];
            string[] numeroPlaca = new string[capacidadVector];
            string[] fecha = new string[capacidadVector];
            int[] tipoVehiculo = new int[capacidadVector];
            string[] hora = new string[capacidadVector];
            int[] numeroCaseta = new int[capacidadVector];
            decimal[] montoPagar = new decimal[capacidadVector];
            decimal[] pagaCon = new decimal[capacidadVector];
            decimal[] vuelto = new decimal[capacidadVector];

            // Inicializar los elementos de tipo int en cero y los elementos de tipo string en cadena vacía
            for (int i = 0; i < capacidadVector; i++)
            {
                numeroFactura[i] = 0;
                numeroPlaca[i] = "";
                fecha[i] = "";
                tipoVehiculo[i] = 0;
                hora[i] = "";
                numeroCaseta[i] = 0;
                montoPagar[i] = 0;
                pagaCon[i] = 0;
                vuelto[i] = 0;
            }

            Console.WriteLine("Vectores inicializados con éxito.");
        }
    }
}
