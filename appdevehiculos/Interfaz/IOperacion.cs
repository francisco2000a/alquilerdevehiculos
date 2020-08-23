using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos.Interfaz
{
    // Creacion de la interfaz para utilizar el patron strategy.
    interface IOperacion
    {
        List<Vehiculo> listarVehiculo();
        Boolean registrarVehiculo(Vehiculo vehiculo);
    }
}
