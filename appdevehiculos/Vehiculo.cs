using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos
{

    public class Vehiculo
    {
        public Vehiculo(String matricula, String modelo, String color, String marca, float precio_alquiler_dias)

        {
            this.Matricula = matricula;
            this.Color = color;
            this.Marca = marca;
            this.Precio_Alquiler_Dias = precio_alquiler_dias;


        }

        public Vehiculo()
        {
        }

        public String Matricula;

        public String matricuala
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        private String Color;

        public String color
        {
            get { return Color; }
            set { Color = value; }
        }
        private String Marca;

        public String marca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        private float Precio_Alquiler_Dias;

        public float precio_alquiler_dias
        {
            get { return Precio_Alquiler_Dias; }
            set { Precio_Alquiler_Dias = value; }
        }



    }
}
