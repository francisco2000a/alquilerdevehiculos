using appdevehiculos.clases;
using appdevehiculos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;

namespace appdevehiculos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int opcion;
            // Instancias para usar el patron de strategy.
            IOperacion operacionMoto = new Moto();
            IOperacion operacionAuto = new Auto();
            ICliente cliente = new Cliente();
            do
            {
                Console.WriteLine("Elija alguna de las opciones:\n");
                Console.WriteLine("--- Modulo de los Vehiculos ---\n");
                Console.WriteLine("Elija 1 para registrar un Carro");
                Console.WriteLine("Elija 2 para registrar una Moto");
                Console.WriteLine("Elija 3 para listar todos los Carros");
                Console.WriteLine("Elija 4 para listar todas las Motos");
                Console.WriteLine("Elija 5 para consultar un Carro");
                Console.WriteLine("Elija 6 para consultar una Moto");
                Console.WriteLine("\n--- Modulo de los Clientes ---\n");
                Console.WriteLine("Elija 7 para registrar un cliente");
                Console.WriteLine("Elija 8 para listar los clientes");
                Console.WriteLine("Elija 9 para consultar un cliente");
                Console.WriteLine("Elija 10 para modificar los datos de un cliente");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        registrar(operacionAuto);
                        break;
                    case 2:
                        registrar(operacionMoto);
                        break;
                    case 3:
                        listar(operacionAuto);
                        break;
                    case 4:
                        listar(operacionMoto);
                        break;
                    case 5:
                        findByMatricula(operacionAuto);
                        break;
                    case 6:
                        findByMatricula(operacionMoto);
                        break;
                    case 7:
                        addClient(cliente);
                        break;
                    case 8:
                        listClient(cliente);
                        break;
                    case 9:
                        findByCliente(cliente);
                        break;
                    case 10:
                        updateClient(cliente);
                        break;
                    default:
                        Console.WriteLine("No has selecionado correctamente, bye");
                        Console.Clear();
                        break;
                }

            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5 || opcion == 6
                     || opcion == 7 || opcion == 8 || opcion == 9 || opcion == 10
                     );

            Console.ReadKey();

        }

        static void registrar(IOperacion operacion)
        {
            Console.Write("A continuacion ingrese detalles del vehiculo: \n");

            Console.WriteLine("Ingrese la matricula:");
            string matricula = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el color:");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de alquiler por dia:");
            double precio = Convert.ToDouble(Console.ReadLine());

            Vehiculo moto = new Vehiculo(matricula, modelo, marca, color, precio);
            Boolean valid = operacion.registrarVehiculo(moto);
            if (valid)
            {
                Console.WriteLine();
                Console.WriteLine("Se registro bien el vehiculo!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No se registro");
            }
        }

        static void listar(IOperacion operacion)
        {
            Console.WriteLine("**** VEHICULOS ****");
            operacion.listarVehiculo();
        }

        static void findByMatricula(IOperacion operacion)
        {
            Console.WriteLine("Ingrese la matricula:");
            string matricula = Console.ReadLine();
            Console.WriteLine("**** CONSULTA DEL VEHICULO ****");
            operacion.findByMatricula(matricula);
        }

        /* Informacion del cliente 
         * Metodos 
         */
        static void addClient(ICliente client)
        {
            Console.Write("A continuacion ingrese la informacion del cliente: \n");

            Console.WriteLine("Ingrese la cedula:");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono:");
            string telefono = Console.ReadLine();
            Cliente clientes = new Cliente(cedula, nombre, direccion, telefono);
            client.addClient(clientes);
        }

        static void listClient(ICliente client)
        {
            Console.WriteLine("**** CLIENTES ****");
            client.listClient();
        }

        static void findByCliente(ICliente client)
        {
            Console.WriteLine("Ingrese la cedula que desea consultar:");
            string cedula = Console.ReadLine();
            Console.WriteLine("**** CONSULTA DE CLIENTE ****");
            client.findByClient(cedula);
        }

        static void updateClient(ICliente client)
        {
            Console.WriteLine("Ingrese la cedula:");
            string cedula = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono:");
            string telefono = Console.ReadLine();
            Cliente clientes = new Cliente(nombre, direccion, telefono);
            client.updateClient(cedula, clientes);
        }
    }
}
