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
            IAlquiler alquiler = new Alquiler();
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.WriteLine("Elija 11 para eliminar un cliente");
                Console.WriteLine("\n--- Modulo para gestionar el alquiler ---\n");
                Console.WriteLine("Elija 12 para registrar un alquiler");
                Console.WriteLine("Elija 13 para consultar una factura en especial");
                Console.WriteLine("Elija 14 para consultar todas las facturas");
                Console.ResetColor();
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
                    case 11:
                        deleteClient(cliente);
                        break;
                    case 12:
                        Console.WriteLine("Selecciona el tipo de vehiculo: \n " +
                                          "1. Para Carros \n " + "2. Para Motos \n");
                        int tipo = Convert.ToInt32(Console.ReadLine());
                        if (tipo == 1)
                            addAlquiler(alquiler, cliente, operacionAuto);
                        else if (tipo == 2)
                            addAlquiler(alquiler, cliente, operacionMoto);
                        break;
                    case 13:
                        listFactByCod(alquiler);
                        break;
                    case 14:
                        listAlquiler(alquiler);
                        break;
                    default:
                        Console.WriteLine("No has selecionado correctamente, bye");
                        Console.Clear();
                        break;
                }

            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5 || opcion == 6
                     || opcion == 7 || opcion == 8 || opcion == 9 || opcion == 10 || opcion == 11 || opcion == 12
                     || opcion == 13 || opcion == 14
                     );
          
            Console.ReadKey();

        }

        static void registrar(IOperacion operacion)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("A continuacion ingrese detalles del vehiculo: \n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
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
                Console.ResetColor();
                Vehiculo moto = new Vehiculo(matricula, modelo, marca, color, precio);
                Boolean valid = operacion.registrarVehiculo(moto);
                if (valid)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Se registro bien el vehiculo!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No se registro");
                    Console.ResetColor();
                }
            } catch(Exception e)
            {
                Console.WriteLine("Error al registrar el vehiculo = " + e.Message);
            }
        }

        static void listar(IOperacion operacion)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("**** VEHICULOS ****");
            operacion.listarVehiculo();
        }

        static void findByMatricula(IOperacion operacion)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ingrese la matricula:");
            string matricula = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("**** CONSULTA DEL VEHICULO ****");
            operacion.findByMatricula(matricula);
            Console.ResetColor();
        }

        /* Informacion del cliente 
         * Metodos 
         */

        static void addClient(ICliente client)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("A continuacion ingrese la informacion del cliente: \n");

            Console.WriteLine("Ingrese la cedula:");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono:");
            string telefono = Console.ReadLine();
            Console.ResetColor();
            Cliente clientes = new Cliente(cedula,nombre,direccion,telefono);
            var result = client.addClient(clientes);
            if (result)
                Console.WriteLine("Se registro el cliente correctamente!");
            else
                Console.WriteLine("No pudimos resolver la operacion!");
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
            Console.WriteLine("Ingrese la cedula del cliente:");
            string cedula = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono:");
            string telefono = Console.ReadLine();
            Cliente clientes = new Cliente(nombre, direccion, telefono);
            var result = client.updateClient(cedula, clientes);
            if (result)
                Console.WriteLine("\n Se actualizó correctamente! \n");
            else
                Console.WriteLine("\n No pudimos resolver la operacion! \n");
        }

        static void deleteClient(ICliente client)
        {
            Console.WriteLine("Ingrese la cedula del cliente:");
            string cedula = Console.ReadLine();
            var result = client.deleteClient(cedula);
            if (result)
                Console.WriteLine("\n Se elimino correctamente! \n");
            else
                Console.WriteLine("\n No pudimos resolver la operacion! \n");
        }

        /* Informacion del alquiler
         * Metodos 
         */
         
        static void addAlquiler(IAlquiler alquilers, ICliente client, IOperacion operacion)
        {
            Console.Write("A continuacion ingrese el detalle del alquiler: \n");

            Console.WriteLine("Ingrese la matricula:");
            string matricula = Console.ReadLine();
            var vehiculo = operacion.darVehiculo(matricula);
            Console.WriteLine("Ingrese la cedula del cliente:");
            string cedula = Console.ReadLine();
            var cliente = client.darClient(cedula);
            Console.WriteLine("Ingrese la fecha fin:");
            string fecha_fin = Console.ReadLine();
            if(vehiculo == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("**** No se encuentra el vehiculo con la matricula numero " + matricula + " ****");
                Console.ResetColor();
            }
            if(cliente == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("**** No se encuentra el cliente con la cedula numero " + cedula + " ****");
                Console.ResetColor();
            }
            else
            {
                Alquiler alquiler = new Alquiler(vehiculo, cliente, fecha_fin);
                var result = alquilers.addAlquiler(alquiler);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("**** Generado Correctamente! ****");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("---- Deseas imprimir la factura por pantalla? ----");
                Console.WriteLine("1.SI\n2.NO");
                int imp = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                if(imp == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("**** Detalle de Factura ****");
                    Console.WriteLine(result);
                    Console.ResetColor();
                }
                else if (imp == 2)
                {
                    return;
                }
            }
        }

        static void listAlquiler(IAlquiler alquilers)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("**** Detalle de Factura ****");
            alquilers.listAllFacturas();
            Console.ResetColor();
        }

        static void listFactByCod(IAlquiler alquilers)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Los codigos de factura disponibles son:");
            var cod = alquilers.darCodigos();
            foreach (var item in cod)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---- Ingrese el codigo de factura que desea consultar ----");
            Console.ResetColor();
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string resultado = alquilers.listFacturaByCodigo(codigo);
            Console.WriteLine("**** Detalle de Factura ****");
            Console.WriteLine(resultado);
            Console.ResetColor();
        }
    }
}
