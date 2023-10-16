using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pratica22
{
    internal class Opcion5
    {
        
         public static void GenerarReporte()
            {
            int cantidadRegistros = Opcion2.contador; // Usar el contador de Opcion2 como cantidad de registros
            int[] numeroFactura = Opcion2.numeroFactura;
            string[] numeroPlaca = Opcion2.numeroPlaca;
            int[] tipoVehiculo = Opcion2.tipoVehiculo;
            int[] numeroCaseta = Opcion2.numeroCaseta;
            decimal[] montoPagar = Opcion2.montoPagar;
            decimal [] pagaCon = Opcion2.pagaCon;
            decimal [] vuelto = Opcion2.vuelto;

            Console.WriteLine("Título del Reporte");
                Console.WriteLine("N factura\tPlaca\ttipo de vehículo\tcaseta\tmonto Pagar\tpaga con\tvuelto");
                Console.WriteLine("=============================================================================");

                decimal totalMontoPagar = 0;
                int totalCantidadVehiculos = 0;

                for (int i = 0; i < cantidadRegistros; i++)
                {
                    Console.WriteLine($"{numeroFactura[i]}\t{numeroPlaca[i]}\t{tipoVehiculo[i]}\t{numeroCaseta[i]}\t{montoPagar[i]}\t{pagaCon[i]}\t{vuelto[i]}");

                    totalMontoPagar += montoPagar[i];
                    totalCantidadVehiculos++;
                }

                Console.WriteLine("=============================================================================");
                Console.WriteLine($"Cantidad de vehículos: {totalCantidadVehiculos}\ttotal: {totalMontoPagar}");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("<<<Pulse tecla para regresar >>>");
                Console.ReadKey();
            }
        
    }
}
