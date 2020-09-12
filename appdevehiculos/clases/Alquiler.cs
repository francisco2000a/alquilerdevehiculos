using appdevehiculos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevehiculos.clases
{
    class Alquiler : IAlquiler
    {
        public int ID { get; set; }
        Vehiculo vehiculo;
        Cliente cliente;
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }

        private List<Vehiculo> Vehiculos { get; set; }
        private List<Cliente> Clientes { get; set; }
        List<Alquiler> alquilers = new List<Alquiler>();

        public Alquiler()
        {

        }

        public Alquiler(Vehiculo vehiculos, Cliente cliente, string fecha_fin)
        {
            var random = new Random();
            this.ID = random.Next();
            this.vehiculo = vehiculos;
            this.cliente = cliente;
            Fecha_Inicio = DateTime.Now.ToString();
            this.Fecha_Fin = fecha_fin;
        }

        public string addAlquiler(Alquiler alquiler)
        {
            try
            {
                if (alquiler.vehiculo == null && alquiler.cliente == null)
                {
                    return "El vehiculo o el cliente no existe!";
                }
                else
                {
                    alquilers.Add(alquiler);
                    return listFacturaByCodigo(alquiler.ID);
                }
            }
            catch (Exception e)
            {
                return "Hubo un fallo en el sistema " + e.Message;
            }
        }

        public void listAllFacturas()
        {
            var consulta = alquilers.Select(x => new {
                Id = x.ID,
                cedula = x.cliente.Cedulacliente,
                nombre = x.cliente.Nombre,
                matricula = x.vehiculo.Matricula,
                marca = x.vehiculo.Marca,
                modelo = x.vehiculo.Modelo,
                precio = x.vehiculo.Precio_Alquiler,
                Fecha_inicio = x.Fecha_Inicio,
                Fecha_fin = x.Fecha_Fin
            }).ToList();

            foreach (var alq in consulta)
            {
                Console.WriteLine("\n Codigo Factura: " + alq.Id + "\n Cedula: " + alq.cedula + "\n Nombre: "
                                    + alq.nombre + "\n Matricula: " + alq.matricula + "\n Marca: " + alq.marca
                                    + "\n Modelo: " + alq.modelo + "\n Valor: $" + alq.precio + "\n Fecha Inicio: " + alq.Fecha_inicio
                                    + "\n fecha: " + alq.Fecha_fin);
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        public string listFacturaByCodigo(int codigo)
        {
            string factura = "";
            try
            {
                foreach (var item in alquilers)
                {
                    if (item.ID == codigo)
                    {
                        var consulta = alquilers.Select(x => new {
                            Id = x.ID,
                            cedula = x.cliente.Cedulacliente,
                            nombre = x.cliente.Nombre,
                            matricula = x.vehiculo.Matricula,
                            marca = x.vehiculo.Marca,
                            modelo = x.vehiculo.Modelo,
                            precio = x.vehiculo.Precio_Alquiler,
                            Fecha_inicio = x.Fecha_Inicio,
                            Fecha_fin = x.Fecha_Fin
                        }).ToList();

                        foreach (var alq in consulta)
                        {
                            factura = "\n Codigo Factura: " + alq.Id + "\n Cedula: " + alq.cedula + "\n Nombre: "
                                                + alq.nombre + "\n Matricula: " + alq.matricula + "\n Marca: " + alq.marca
                                                + "\n Modelo: " + alq.modelo + "\n Valor: $" + alq.precio + "\n Fecha Inicio: " + alq.Fecha_inicio
                                                + "\n fecha: " + alq.Fecha_fin + "\n -------------";
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            return factura;
        }

        public IEnumerable<int> darCodigos()
        {
            IEnumerable<int> codigos = new List<int>();
            for (int i = 0; i < alquilers.Count; i++)
            {
                codigos = alquilers.Select(x => x.ID);
            }
            return codigos;
        }
    }
}
