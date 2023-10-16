using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica22
{
    internal class Opcion4
    {
        public static void Modicar()
        {
            Opcion3.ConsultarNumeroPlaca();
            Console.WriteLine("¿Desea realizar modificaciones? (S/N)");
            string respuesta = Console.ReadLine();

            if (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                // Permitir al usuario modificar los datos, por ejemplo:
                Console.WriteLine("Ingrese el nuevo tipo de vehículo: ");
                int nuevoTipoVehiculo = int.Parse(Console.ReadLine());

                // Actualizar los datos en Opcion2 o en la estructura de datos que estés utilizando
                // Por ejemplo:
                Opcion2.tipoVehiculo[0] = nuevoTipoVehiculo;

                Console.WriteLine("Datos modificados exitosamente.");

                Console.WriteLine("Ingrese el nuevo numero de Facutra: ");
                int nuevafactura = int.Parse(Console.ReadLine());

                Opcion2.numeroFactura[0] = nuevafactura;

                Console.WriteLine("Datos modificados exitosamente.");

                Console.WriteLine("Ingrese la nueva fecha: ");
                string nuevafecha = (Console.ReadLine());

                Opcion2.fecha[0] = nuevafecha;

                Console.WriteLine("Datos modificados exitosamente.");

                Console.WriteLine("ingrese la nueva hora: ");
                string nuevahora = (Console.ReadLine());

                Opcion2.hora[0] = nuevahora;

                Console.WriteLine("Datos modificados exitosamente.");

                Console.WriteLine("Ingrese la nueva caseta: ");
                int nuevacaseta = int.Parse(Console.ReadLine());

                Opcion2.numeroCaseta[0] = nuevacaseta;

                Console.WriteLine("Datos modificados exitosamente.");

                Console.WriteLine("Ingrese el nuevo monto para pagar: ");
                decimal montopaga = decimal.Parse(Console.ReadLine());

                Opcion2.montoPagar[0] = montopaga;

                Console.WriteLine("Datos modificados exitosamente.");

                Console.WriteLine("Ingrese el nuevo monto pagado ");
                decimal nuevapaga = decimal.Parse(Console.ReadLine());

                Opcion2.pagaCon[0] = nuevapaga;

                Console.WriteLine("Datos modificados exitosamente.");

                Console.WriteLine("Ingrese el nuevo vuelto: ");
                decimal nuevovuelto = decimal.Parse(Console.ReadLine());

                Opcion2.vuelto[0] = nuevovuelto;

                Console.WriteLine("Datos modificados exitosamente.");



            }
            else
            {
                Console.WriteLine("No se realizaron modificaciones.");
            }
        }
    }
}
    
