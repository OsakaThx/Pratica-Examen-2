using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pratica22
{
    class Program
    {
        // Atributo
        static int opcion = 0;

        // Método Main
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Ingresar paso vehicular");
                Console.WriteLine("3- Consulta de vehículos por número de placa");
                Console.WriteLine("4- Modificar datos de vehículos por número de placa");
                Console.WriteLine("5- Reportar todos los datos de los vectores");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opción:");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Opcion1.Inicializar();
                        break;

                    case 2:
                        Console.Clear();
                        Opcion2.datos();
                        break;

                    case 3:
                        Console.Clear();
                        Opcion3.ConsultarNumeroPlaca();
                        // Aquí puedes implementar la lógica para la opción 3
                        break;

                    case 4:
                        Console.Clear();
                        Opcion4.Modicar();
                        // Aquí puedes implementar la lógica para la opción 4
                        break;

                    case 5:
                        Opcion5.GenerarReporte();
                        Console.Clear();
                        break;



                    case 6:
                        Console.WriteLine("Saliendo del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            } while (opcion != 6);
        }
    }
}



