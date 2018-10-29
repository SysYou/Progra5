using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.DiegoRM.Logica.Especificacion
{
    public class Area_PolRegular
    {

        public double Area_PolRegula(double lado, double apotema, int cant_lados)
        {
            var laAccion = new Practica.Examen.DiegoRM.Logica.Accion.Area_PolRegular();
            double elResultado = laAccion.Area_PolRegula(lado, apotema, cant_lados);
            return elResultado;
        }

    }
}