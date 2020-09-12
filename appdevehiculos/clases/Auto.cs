using appdevehiculos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appdevehiculos.clases
{
    // Implementacion de la interfaz IOperacion en la clase Auto.
    class Auto : IOperacion
    {
        public List<Vehiculo> carro = new List<Vehiculo>();

        /* 
        * Metodos de la interfaz IOperacion.
        */

        public bool registrarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                carro.Add(vehiculo);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void listarVehiculo()
        {
            var consulta = carro.Select(x => new {
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
            var consulta = carro.Where(x => x.Matricula.Equals(matricula)).Select(x => new
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

        public Vehiculo darVehiculo(string matricula)
        {
            Vehiculo res_vehiculo = null;
            try
            {
                foreach (var item in carro)
                {
                    if (item.Matricula == matricula)
                    {
                        res_vehiculo = item;
                    }
                }

            }
            catch (Exception e)
            {

            }
            return res_vehiculo;
        }
    }
}
