using appdevehiculos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevehiculos.clases
{
    // Implementacion de la interfaz IOperacion en la clase Moto.
    class Moto : IOperacion
    {
        private List<Vehiculo> moto = new List<Vehiculo>();

        /* 
        * Metodos de la interfaz IOperacion.
        */

        public bool registrarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                moto.Add(vehiculo);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void listarVehiculo()
        {
            var consulta = moto.Select(x => new {
                matricula = x.Matricula,
                modelo = x.Modelo,
                marca = x.Marca,
                color = x.Color,
                precio = x.Precio_Alquiler
            }).ToList();

            foreach (var car in consulta)
            {
                Console.WriteLine("\n Matricula: " + car.matricula + "\n Marca: " + car.marca +
                                  "\n Modelo: " + car.modelo + "\n Color " + car.color + "\n Precio Dia: " + car.precio);
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        public void findByMatricula(string matricula)
        {
            var consulta = moto.Where(x => x.Matricula.Equals(matricula)).Select(x => new
            {
                matricula = x.Matricula,
                modelo = x.Modelo,
                marca = x.Marca,
                color = x.Color,
                precio = x.Precio_Alquiler
            }).ToList();

            foreach (var car in consulta)
            {
                Console.WriteLine("\n Matricula: " + car.matricula + "\n Marca: " + car.marca +
                                  "\n Modelo: " + car.modelo + "\n Color " + car.color + "\n Precio Dia: " + car.precio);
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }
    }
}
