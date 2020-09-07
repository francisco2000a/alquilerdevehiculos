using System;
using System.Collections.Generic;
using System.Text;

namespace appdevehiculos

{ class Reserva : Lista_Cliente
{
    public Reserva(int cod_reserva, DateTime fecha_salida, DateTime fecha_entrada, float precio_total, Boolean indicador_de_entrada, float gasolina)
    {
        this.Cod_Reserva = cod_reserva;
        this.Fecha_Salida = fecha_salida;
        this.Fecha_Entrada = fecha_entrada;
        this.Precio_Total = precio_total;
        this.Indicador_De_Entrega = indicador_de_entrada;
        this.Gasolina = gasolina;
            
    }

    public int Cod_Reserva { get; private set; }
    public DateTime Fecha_Salida { get; private set; }
    public DateTime Fecha_Entrada { get; private set; }

    public float Precio_Total { get; private set; }

    public Boolean Indicador_De_Entrega { get; private set; }
    public float Gasolina { get; private set; }
}
}