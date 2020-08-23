using appdevehiculos.clases;
using appdevehiculos.Interfaz;
using System;

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
            do
            {
                Console.WriteLine("Elija alguna de las opciones: ");
                Console.WriteLine("Elija 1 para registrar un Carro");
                Console.WriteLine("Elija 2 para registrar una Moto");
                Console.WriteLine("Elija 3 para Listar todos los Carros");
                Console.WriteLine("Elija 4 para Listar todas las Motos");
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
                    default:
                        Console.WriteLine("No has selecionado correctamente, bye");
                        break;
                }

            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4);

            //Cliente cliente = new Cliente();
            //Console.Write("A continuacion ingrese los datos del cliente: ");

            //Console.WriteLine("Ingrese sus nombres");
            //cliente.Nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese su numero de telefono: ");
            //cliente.Telefono = Console.ReadLine();
            //Console.WriteLine("Ingres su direccion: ");
            //cliente.Direccion = Console.ReadLine();

            //Console.WriteLine("Ingres su codigo de cliente: ");
            //cliente.Codigocliente = Console.ReadLine();

            //Console.WriteLine("ingrese cedula");
            //cliente.Cedulacliente = Console.ReadLine();            
            Console.ReadKey();

        }

        static void registrar(IOperacion operacion)
        {
            Console.Write("A continuacion ingrese detalles del vehiculo: ");

            Console.WriteLine("Ingrese la matricula");
            string matricula = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de alquiler por dia");
            double precio = Convert.ToDouble(Console.ReadLine());

            Vehiculo moto = new Vehiculo(matricula, modelo, marca, color, precio);
            Boolean valid = operacion.registrarVehiculo(moto);
            if (valid)
            {
                Console.WriteLine();
                Console.WriteLine("Se registro bien el vehiculo");
                Console.WriteLine();
            } else
            {
                Console.WriteLine("No se registro");
            }
        }

        static void listar(IOperacion operacion)
        {
            if (operacion.listarVehiculo().Count <= 0)
            {
                Console.WriteLine("No hay datos");
            }
            else
            {
                foreach (var lista in operacion.listarVehiculo())
                {
                    Console.WriteLine();
                    Console.WriteLine("MATRICULA:" + lista.getMatricula());
                    Console.WriteLine("MARCA:" + lista.getMarca());
                    Console.WriteLine("MODELO:" + lista.getModelo());
                    Console.WriteLine("COLOR:" + lista.getColor());
                    Console.WriteLine("PRECIO DIA:" + lista.getPrecioDia());
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                }
            }
        }
    }
}
