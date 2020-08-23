using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos
{
    class Garaje : Lista_Cliente
    {
        public Garaje(int cod_Garaje, String nombre_garaje)
        {
            this.Cod_Garaje = cod_Garaje;
            this.Nombre_Garaje = nombre_garaje;
        }
        public int Cod_Garaje { get; private set; }
        public String Nombre_Garaje { get; set; }



    }
}