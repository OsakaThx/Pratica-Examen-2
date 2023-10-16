using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica22
{
    internal class Opcion3
    {
        public static void ConsultarNumeroPlaca()
        {
            Console.WriteLine("Ingrese el número de placa:");
            string placaBuscada = Console.ReadLine(); // Leer el número de placa ingresado por el usuario

            // Supongamos que las matrices de Opcion2 son públicas y accesibles
            for (int i = 0; i < Opcion2.numeroPlaca.Length; i++)
            {
                if (placaBuscada == Opcion2.numeroPlaca[i])
                {
                    // Se encontró una coincidencia, muestra los datos asociados
                    int numFactura = Opcion2.numeroFactura[i];
                    string numPlaca = Opcion2.numeroPlaca[i];
                    string fechaa = Opcion2.fecha[i];
                    int tipVehiculo = Opcion2.tipoVehiculo[i];
                    string horaa = Opcion2.hora[i];
                    int numeCaseta = Opcion2.numeroCaseta[i];
                    decimal montoPagar = Opcion2.montoPagar[i];
                    decimal pagaCon = Opcion2.pagaCon[i];
                    decimal vuelto = Opcion2.vuelto[i];

                    Console.WriteLine($"Factura: {numFactura}");
                    Console.WriteLine($"Placa: {numPlaca}");
                    Console.WriteLine($"Fecha: {fechaa}");
                    Console.WriteLine($"Tipo de vehículo: {tipVehiculo}");
                    Console.WriteLine($"Hora: {horaa}");
                    Console.WriteLine($"Caseta: {numeCaseta}");
                    Console.WriteLine($"Monto a pagar: {montoPagar}");
                    Console.WriteLine($"Se pagó: {pagaCon}");
                    Console.WriteLine($"Vuelto: {vuelto}");

                    // Agrega aquí otros datos que desees mostrar
                    return;
                }
            }

            // Si llega aquí, no se encontró ninguna coincidencia
            Console.WriteLine("No se encontraron datos para el número de placa ingresado.");
        }
    }
}
