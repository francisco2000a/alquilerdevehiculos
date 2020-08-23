using appdevehiculos.Interfaz;
using System;
using System.Collections.Generic;
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

        public List<Vehiculo> listarVehiculo()
        {
            return moto;
        }

        public bool registrarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                moto.Add(vehiculo);
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }
    }
}
