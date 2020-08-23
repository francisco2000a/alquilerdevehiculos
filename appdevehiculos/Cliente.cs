using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos
{   public class Cliente
{


    public Cliente()
    { }
    //public  Cliente ( String cedulacliente, String nombre, String direccion, int telefono)
    public Cliente(String codigocliente, String cedulacliente, String nombre, String direccion, String telefono)
    {
        this.Codigocliente = codigocliente;
        this.Cedulacliente = cedulacliente;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;


    }

    public string Codigocliente { get; set; }
    public string Cedulacliente { get; set; }
    public String Nombre { get; set; }
    public String Direccion { get; set; }
    public string Telefono { get; set; }





}
}