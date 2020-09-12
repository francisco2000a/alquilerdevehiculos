using appdevehiculos.clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos.Interfaz
{
    interface IAlquiler
    {
        string addAlquiler(Alquiler alquiler);
        IEnumerable<int> darCodigos();
        string listFacturaByCodigo(int codigo);
        void listAllFacturas();
    }
}
