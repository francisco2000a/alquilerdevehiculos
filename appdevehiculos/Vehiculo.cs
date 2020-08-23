using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos
{

    public class Vehiculo
    {
        private string matricula;
        private string modelo;
        private string marca;
        private string color;
        private double precio_alquiler_dias;

        public Vehiculo(string matricula, string modelo, string marca, string color, double precio)
        {
            this.matricula = matricula;
            this.modelo = modelo;
            this.marca = marca;
            this.color = color;
            this.precio_alquiler_dias = precio;
        }

        public Vehiculo()
        {
        }

        public string getMatricula()
        {
            return matricula;
        }

        public void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getPrecioDia()
        {
            return precio_alquiler_dias;
        }

        public void setPrecio(double precio)
        {
            this.precio_alquiler_dias = precio;
        }
    }
}
