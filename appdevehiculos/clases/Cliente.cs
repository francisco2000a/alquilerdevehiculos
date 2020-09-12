using appdevehiculos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevehiculos
{
    public class Cliente: ICliente
    {
        public int Codigocliente { get; set; }
        public string Cedulacliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        List<Cliente> clientes = new List<Cliente>();

        public Cliente(string cedulacliente, string nombre, string direccion, string telefono)
        {
            var random = new Random();
            this.Codigocliente = random.Next();
            this.Cedulacliente = cedulacliente;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public Cliente( string nombre, string direccion, string telefono)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public Cliente() { }

        public bool addClient(Cliente cliente)
        {
            try
            {
                clientes.Add(cliente);
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }

        public bool updateClient(string cedula, Cliente cliente)
        {
            try
            {
                foreach (var item in clientes)
                {
                    if (item.Cedulacliente == cedula)
                    {
                        item.Nombre = cliente.Nombre;
                        item.Direccion = cliente.Direccion;
                        item.Telefono = cliente.Telefono;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void listClient()
        {
            var consulta = clientes.Select(x => new {
                codigo = x.Codigocliente,
                cedula = x.Cedulacliente,
                nombre = x.Nombre,
                direccion = x.Direccion,
                telefono = x.Telefono
            }).ToList();

            foreach (var cliente in consulta)
            {
                Console.WriteLine("\n Codigo Cliente: " + cliente.codigo + "\n Cedula: " + cliente.cedula + "\n Nombres: " + 
                                  cliente.nombre + "\n Direccion: " + cliente.direccion + "\n Telefono: " + cliente.telefono);
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        public void findByClient(string cedula)
        {
            var consulta = clientes.Where(x => x.Cedulacliente.Equals(cedula)).Select(x => new
            {
                codigo = x.Codigocliente,
                cedula = x.Cedulacliente,
                nombre = x.Nombre,
                direccion = x.Direccion,
                telefono = x.Telefono
            }).ToList();

            foreach (var cliente in consulta)
            {
                Console.WriteLine("\n Codigo Cliente: " + cliente.codigo + "\n Cedula: " + cliente.cedula + "\n Nombres: " +
                                  cliente.nombre + "\n Direccion: " + cliente.direccion + "\n Telefono: " + cliente.telefono);
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        public bool deleteClient(string cedula)
        {
            try
            {
                foreach (var item in clientes)
                {
                    if (item.Cedulacliente == cedula)
                    {
                        clientes.Remove(item);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
   
        public Cliente darClient(string cedula)
        {
            Cliente res_client = null;
            try
            {
                foreach (var item in clientes)
                {
                    if (item.Cedulacliente == cedula)
                    {
                        res_client = item;
                    }
                }

            }
            catch (Exception e)
            {

            }
            return res_client;
        }
    }
}