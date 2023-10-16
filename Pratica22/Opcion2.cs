using System;

namespace Pratica22
{
    internal class Opcion2
    {
        
            public static int capacidadVector = 15; // Capacidad máxima del vector
            public static int[] numeroFactura = new int[capacidadVector];
            public static string[] numeroPlaca = new string[capacidadVector];
            public static string[] fecha = new string[capacidadVector];
            public static int[] tipoVehiculo = new int[capacidadVector];
            public static string[] hora = new string[capacidadVector];
            public static int[] numeroCaseta = new int[capacidadVector];
            public static decimal[] montoPagar = new decimal[capacidadVector];
            public static decimal[] pagaCon = new decimal[capacidadVector];
            public static decimal[] vuelto = new decimal[capacidadVector];
            public static int contador = 0; // Para llevar un seguimiento de la cantidad de registros

        public static void datos()
        {

            

            string continuar = "S"; //Inicializar 'continuar'

            do
            {
                Console.WriteLine("REGISTRAR FLUJO VEHICULAR");
                Console.Write("Numero Factura: ");
                numeroFactura[contador] = int.Parse(Console.ReadLine());

                Console.Write("Numero PLACA: ");
                numeroPlaca[contador] = Console.ReadLine();

                Console.Write("Fecha: ");
                fecha[contador] = Console.ReadLine();

                Console.Write("Hora: ");
                hora[contador] = Console.ReadLine();

                do
                {
                    Console.WriteLine("Tipo de vehículo: ");
                    Console.WriteLine("[1= Moto   2= Vehículo Liviano   3=Camión o Pesado   4=Autobús]");
                    if (!int.TryParse(Console.ReadLine(), out tipoVehiculo[contador]))
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }
                    else if (tipoVehiculo[contador] < 1 || tipoVehiculo[contador] > 4)
                    {
                        Console.WriteLine("Tipo de vehículo no válido. Debe ser 1, 2, 3 o 4.");
                    }
                } while (tipoVehiculo[contador] < 1 || tipoVehiculo[contador] > 4);


                do
                {
                    Console.WriteLine("Tipo de vehículo: ");
                    Console.WriteLine("[1= Moto   2= Vehículo Liviano   3=Camión o Pesado   4=Autobús]");
                    if (!int.TryParse(Console.ReadLine(), out tipoVehiculo[contador]))
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }
                    else if (tipoVehiculo[contador] < 1 || tipoVehiculo[contador] > 4)
                    {
                        Console.WriteLine("Tipo de vehículo no válido. Debe ser 1, 2, 3 o 4.");
                    }
                } while (tipoVehiculo[contador] < 1 || tipoVehiculo[contador] > 4);


                // Asignar el monto a pagar según el tipo de vehículo
                switch (tipoVehiculo[contador])
                {
                    case 1:
                        montoPagar[contador] = 500; // Moto
                        break;
                    case 2:
                        montoPagar[contador] = 700; // Vehículo Liviano
                        break;
                    case 3:
                        montoPagar[contador] = 2700; // Camión o Pesado
                        break;
                    case 4:
                        montoPagar[contador] = 3700; // Autobús
                        break;
                    default:
                        Console.WriteLine("Tipo de vehículo no válido.");
                        continue; // Regresar al inicio del ciclo
                }

                Console.Write("Monto a pagar: " + montoPagar[contador]);

                Console.Write("Paga con: ");
                pagaCon[contador] = decimal.Parse(Console.ReadLine());

                vuelto[contador] = pagaCon[contador] - montoPagar[contador];

                Console.Write("Vuelto: " + vuelto[contador]);

                contador++;

                Console.Write("Desea continuar S/N? ");
                continuar = Console.ReadLine();
            } while (continuar.Equals("S", StringComparison.OrdinalIgnoreCase) && contador < capacidadVector);

            // Aquí puedes realizar otras operaciones con los datos si es necesario

            // Mostrar todos los registros
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Registro {i + 1}:");
                Console.WriteLine($"Numero Factura: {numeroFactura[i]}");
                Console.WriteLine($"Numero PLACA: {numeroPlaca[i]}");
                Console.WriteLine($"Fecha: {fecha[i]}");
                Console.WriteLine($"Hora: {hora[i]}");
                Console.WriteLine($"Tipo de vehículo: {tipoVehiculo[i]}");
                Console.WriteLine($"Numero caseta: {numeroCaseta[i]}");
                Console.WriteLine($"Monto a pagar: {montoPagar[i]}");
                Console.WriteLine($"Paga con: {pagaCon[i]}");
                Console.WriteLine($"Vuelto: {vuelto[i]}");
                Console.WriteLine();
            }
        }
    }
}



