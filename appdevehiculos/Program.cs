using System;

namespace appdevehiculos
{
    class Program
    {


        static void Main(string[] args)
        {


            Cliente cliente = new Cliente();
            Console.Write("A continuacion ingrese los datos del cliente: ");

            Console.WriteLine("Ingrese sus nombres");
            cliente.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su numero de telefono: ");
            cliente.Telefono = Console.ReadLine();
            Console.WriteLine("Ingres su direccion: ");
            cliente.Direccion = Console.ReadLine();

            Console.WriteLine("Ingres su codigo de cliente: ");
            cliente.Codigocliente = Console.ReadLine();

            Console.WriteLine("ingrese cedula");
            cliente.Cedulacliente = Console.ReadLine();


            Vehiculo vehiculo = new Vehiculo();
            Console.Write("A continuacion ingrese detalles del auto: ");

            Console.WriteLine("Ingrese sus matricula");
            vehiculo.matricuala = Console.ReadLine();

            Console.WriteLine("Ingrese el color: ");
            vehiculo.color = Console.ReadLine();

            Console.WriteLine("Ingres su marca: ");
            vehiculo.marca = Console.ReadLine();










        }
    }
}
