using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos
{

    public class Vehiculo
    {
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public double Precio_Alquiler { get; set; }

        public Vehiculo(string matricula, string modelo, string marca, string color, double precio_Alquiler)
        {
            Matricula = matricula;
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Precio_Alquiler = precio_Alquiler;
        }
    }
}
