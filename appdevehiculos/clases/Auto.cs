using appdevehiculos.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos.clases
{
    // Implementacion de la interfaz IOperacion en la clase Auto.
    class Auto : IOperacion
    {
        private List<Vehiculo> carro = new List<Vehiculo>();

        /* 
        * Metodos de la interfaz IOperacion.
        */

        public List<Vehiculo> listarVehiculo()
        {
            return carro;
        }

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
    }
}
