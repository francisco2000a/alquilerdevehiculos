using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos.Interfaz
{
    interface ICliente
    {
        Boolean addClient(Cliente cliente);
        Boolean updateClient(string cedula, Cliente cliente);
        Boolean deleteClient(string cedula);
        Cliente darClient(string cedula);
        void findByClient(string cedula);
        void listClient();
    }
}
